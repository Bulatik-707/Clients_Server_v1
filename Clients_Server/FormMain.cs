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
