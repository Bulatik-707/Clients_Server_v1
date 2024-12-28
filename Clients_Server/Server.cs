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
