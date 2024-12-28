namespace Clients_Server
{
	partial class FormMain
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
			this.buttonOpenServe = new System.Windows.Forms.Button();
			this.buttonOpenClient = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonOpenServe
			// 
			this.buttonOpenServe.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonOpenServe.Location = new System.Drawing.Point(40, 27);
			this.buttonOpenServe.Name = "buttonOpenServe";
			this.buttonOpenServe.Size = new System.Drawing.Size(118, 34);
			this.buttonOpenServe.TabIndex = 0;
			this.buttonOpenServe.Text = "Open Serve";
			this.buttonOpenServe.UseVisualStyleBackColor = false;
			this.buttonOpenServe.Click += new System.EventHandler(this.buttonOpenServe_Click);
			// 
			// buttonOpenClient
			// 
			this.buttonOpenClient.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonOpenClient.Location = new System.Drawing.Point(40, 89);
			this.buttonOpenClient.Name = "buttonOpenClient";
			this.buttonOpenClient.Size = new System.Drawing.Size(118, 34);
			this.buttonOpenClient.TabIndex = 1;
			this.buttonOpenClient.Text = "Open Client";
			this.buttonOpenClient.UseVisualStyleBackColor = false;
			this.buttonOpenClient.Click += new System.EventHandler(this.buttonOpenClient_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(220, 188);
			this.Controls.Add(this.buttonOpenClient);
			this.Controls.Add(this.buttonOpenServe);
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormMain";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonOpenServe;
		private System.Windows.Forms.Button buttonOpenClient;
	}
}