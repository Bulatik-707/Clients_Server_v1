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
