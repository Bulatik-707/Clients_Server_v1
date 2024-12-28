namespace Clients_Server
{
	partial class Server
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose( bool disposing )
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonStartServer = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxMessages = new System.Windows.Forms.TextBox();
			this.helpProvider1 = new System.Windows.Forms.HelpProvider();
			this.SuspendLayout();
			// 
			// buttonStartServer
			// 
			this.buttonStartServer.BackColor = System.Drawing.SystemColors.Highlight;
			this.buttonStartServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonStartServer.Location = new System.Drawing.Point(87, 210);
			this.buttonStartServer.Name = "buttonStartServer";
			this.buttonStartServer.Size = new System.Drawing.Size(135, 36);
			this.buttonStartServer.TabIndex = 0;
			this.buttonStartServer.Text = "Start Server";
			this.buttonStartServer.UseVisualStyleBackColor = false;
			this.buttonStartServer.Click += new System.EventHandler(this.buttonStartServer_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(33, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(139, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "сообщения сервера ";
			// 
			// textBoxMessages
			// 
			this.textBoxMessages.Location = new System.Drawing.Point(36, 39);
			this.textBoxMessages.Multiline = true;
			this.textBoxMessages.Name = "textBoxMessages";
			this.textBoxMessages.Size = new System.Drawing.Size(226, 151);
			this.textBoxMessages.TabIndex = 2;
			// 
			// Server
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(298, 274);
			this.Controls.Add(this.textBoxMessages);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonStartServer);
			this.Name = "Server";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Server";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonStartServer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxMessages;
		private System.Windows.Forms.HelpProvider helpProvider1;
	}
}

