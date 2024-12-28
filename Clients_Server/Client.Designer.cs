namespace Clients_Server
{
	partial class Client
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonConnect = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxIpAddress = new System.Windows.Forms.TextBox();
			this.textBoxMessage = new System.Windows.Forms.TextBox();
			this.helpProvider1 = new System.Windows.Forms.HelpProvider();
			this.buttonSend = new System.Windows.Forms.Button();
			this.richTextBoxMessages = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonConnect
			// 
			this.buttonConnect.BackColor = System.Drawing.SystemColors.Highlight;
			this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonConnect.Location = new System.Drawing.Point(117, 62);
			this.buttonConnect.Name = "buttonConnect";
			this.buttonConnect.Size = new System.Drawing.Size(100, 37);
			this.buttonConnect.TabIndex = 0;
			this.buttonConnect.Text = "Connect";
			this.buttonConnect.UseVisualStyleBackColor = false;
			this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(116, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "IP-адреса сервера";
			// 
			// textBoxIpAddress
			// 
			this.textBoxIpAddress.Location = new System.Drawing.Point(117, 36);
			this.textBoxIpAddress.Name = "textBoxIpAddress";
			this.textBoxIpAddress.Size = new System.Drawing.Size(122, 20);
			this.textBoxIpAddress.TabIndex = 2;
			this.textBoxIpAddress.Text = "127.0.0.1";
			// 
			// textBoxMessage
			// 
			this.textBoxMessage.Location = new System.Drawing.Point(61, 134);
			this.textBoxMessage.Multiline = true;
			this.textBoxMessage.Name = "textBoxMessage";
			this.textBoxMessage.Size = new System.Drawing.Size(233, 114);
			this.textBoxMessage.TabIndex = 2;
			this.textBoxMessage.Text = "TextBox (Name: textBoxMessage) для ввода сообщения.";
			// 
			// buttonSend
			// 
			this.buttonSend.BackColor = System.Drawing.SystemColors.Highlight;
			this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonSend.Location = new System.Drawing.Point(119, 254);
			this.buttonSend.Name = "buttonSend";
			this.buttonSend.Size = new System.Drawing.Size(100, 37);
			this.buttonSend.TabIndex = 0;
			this.buttonSend.Text = "Send";
			this.buttonSend.UseVisualStyleBackColor = false;
			this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
			// 
			// richTextBoxMessages
			// 
			this.richTextBoxMessages.Location = new System.Drawing.Point(60, 336);
			this.richTextBoxMessages.Name = "richTextBoxMessages";
			this.richTextBoxMessages.Size = new System.Drawing.Size(290, 164);
			this.richTextBoxMessages.TabIndex = 5;
			this.richTextBoxMessages.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(57, 111);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "ввод сообщения";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(57, 306);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(130, 16);
			this.label3.TabIndex = 1;
			this.label3.Text = "ответы от сервера";
			// 
			// Client
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(390, 512);
			this.Controls.Add(this.richTextBoxMessages);
			this.Controls.Add(this.textBoxMessage);
			this.Controls.Add(this.textBoxIpAddress);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonSend);
			this.Controls.Add(this.buttonConnect);
			this.Name = "Client";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Client";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonConnect;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxIpAddress;
		private System.Windows.Forms.TextBox textBoxMessage;
		private System.Windows.Forms.HelpProvider helpProvider1;
		private System.Windows.Forms.Button buttonSend;
		private System.Windows.Forms.RichTextBox richTextBoxMessages;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}