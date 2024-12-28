

Создание клиент-серверного приложения в одном проекте с использованием Windows Forms (WinForms) в .NET Framework,
где сервер и клиент находятся на разных формах. 
Ниже приведен пример, который объединяет сервер и клиент в одном проекте с использованием двух (трех) форм.

o	FormServer — для сервера.
o	FormClient — для клиента.
o FormMain - Главное окно приложения


Реализация кода для главного окна
Вот пример кода для главного окна:
using System;
using System.Windows.Forms;

namespace Clients_Server
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		
		private void buttonOpenServe_Click( object sender, EventArgs e )
		{
			// Open Server, Открыть сервер

			Server serverForm = new Server();
			serverForm.Show();
		}

		
		private void buttonOpenClient_Click( object sender, EventArgs e )
		{
			// Open Client, Открыть клиент

			Client clientForm = new Client();
			clientForm.Show();
		}
	}
} 

---------------------


. Реализация кода для сервера
Вот пример кода для сервера:
using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Clients_Server
{
	public partial class Server : Form
	{
		private TcpListener listener;
		public Server()
		{
			InitializeComponent();
		}

		private void buttonStartServer_Click( object sender, EventArgs e )
		{
			listener = new TcpListener( IPAddress.Any, 5000 );
			listener.Start();
			textBoxMessages.AppendText( "Сервер запущен...\n" );
			AcceptClients();

		}
		private async void AcceptClients()
		{
			while (true)
			{
				var client = await listener.AcceptTcpClientAsync();
				textBoxMessages.AppendText( "Клиент подключен...\n" );
				HandleClient( client );
			}
		}

		private async void HandleClient( TcpClient client )
		{
			NetworkStream stream = client.GetStream();
			byte[] buffer = new byte[1024];
			int bytesRead;

			while ((bytesRead = await stream.ReadAsync( buffer, 0, buffer.Length )) != 0)
			{
				string message = Encoding.UTF8.GetString( buffer, 0, bytesRead );
				textBoxMessages.AppendText( $"Получено: {message}\n" );
			}

			client.Close();
			textBoxMessages.AppendText( "Клиент отключен...\n" );
		}

	}
}


-------------

Реализация кода для клиента
Вот пример кода для клиента:
using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Clients_Server
{
	public partial class Client : Form
	{
		private TcpClient client;
		private NetworkStream stream;

		public Client()
		{
			InitializeComponent();
		}

		private void buttonConnect_Click( object sender, EventArgs e )
		{
			try
			{
				string ipAddress = textBoxIpAddress.Text;
				client = new TcpClient( ipAddress, 5000 );
				stream = client.GetStream();
				richTextBoxMessages.AppendText( "Подключено к серверу...\n" );
			}
			catch (Exception ex)
			{
				richTextBoxMessages.AppendText( $"Ошибка: {ex.Message}\n" );
			}

		}

		private async void buttonSend_Click( object sender, EventArgs e )
		{
			if (stream != null && stream.CanWrite)
			{
				string message = textBoxMessage.Text;
				byte[] data = Encoding.UTF8.GetBytes( message );
				await stream.WriteAsync( data, 0, data.Length );
				richTextBoxMessages.AppendText( $"Отправлено: {message}\n" );
			}

		}
	}
} 
