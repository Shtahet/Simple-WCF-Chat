namespace WcfChatClient
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
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.mainMenu = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.подключитсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.отключитсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnConnect = new System.Windows.Forms.Button();
			this.txtChat = new System.Windows.Forms.TextBox();
			this.lstUsers = new System.Windows.Forms.ListBox();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.lbAboutSend = new System.Windows.Forms.Label();
			this.lbForUser = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripChatStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.mainMenu.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(12, 31);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(259, 20);
			this.txtUserName.TabIndex = 2;
			// 
			// mainMenu
			// 
			this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
			this.mainMenu.Location = new System.Drawing.Point(0, 0);
			this.mainMenu.Name = "mainMenu";
			this.mainMenu.Size = new System.Drawing.Size(517, 24);
			this.mainMenu.TabIndex = 3;
			this.mainMenu.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подключитсяToolStripMenuItem,
            this.отключитсяToolStripMenuItem,
            this.toolStripMenuItem2,
            this.выходToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// подключитсяToolStripMenuItem
			// 
			this.подключитсяToolStripMenuItem.Name = "подключитсяToolStripMenuItem";
			this.подключитсяToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.подключитсяToolStripMenuItem.Text = "Подключится";
			// 
			// отключитсяToolStripMenuItem
			// 
			this.отключитсяToolStripMenuItem.Name = "отключитсяToolStripMenuItem";
			this.отключитсяToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.отключитсяToolStripMenuItem.Text = "Отключится";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(147, 6);
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.выходToolStripMenuItem.Text = "Выход";
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(277, 29);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(100, 23);
			this.btnConnect.TabIndex = 4;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			// 
			// txtChat
			// 
			this.txtChat.BackColor = System.Drawing.Color.White;
			this.txtChat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtChat.Location = new System.Drawing.Point(12, 55);
			this.txtChat.Multiline = true;
			this.txtChat.Name = "txtChat";
			this.txtChat.ReadOnly = true;
			this.txtChat.Size = new System.Drawing.Size(365, 251);
			this.txtChat.TabIndex = 8;
			// 
			// lstUsers
			// 
			this.lstUsers.FormattingEnabled = true;
			this.lstUsers.Location = new System.Drawing.Point(383, 29);
			this.lstUsers.Name = "lstUsers";
			this.lstUsers.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.lstUsers.Size = new System.Drawing.Size(129, 277);
			this.lstUsers.TabIndex = 9;
			// 
			// txtMessage
			// 
			this.txtMessage.Enabled = false;
			this.txtMessage.Location = new System.Drawing.Point(12, 325);
			this.txtMessage.Multiline = true;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(365, 36);
			this.txtMessage.TabIndex = 11;
			// 
			// btnSend
			// 
			this.btnSend.Enabled = false;
			this.btnSend.Location = new System.Drawing.Point(383, 325);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(129, 37);
			this.btnSend.TabIndex = 10;
			this.btnSend.Text = "SEND";
			this.btnSend.UseVisualStyleBackColor = true;
			// 
			// lbAboutSend
			// 
			this.lbAboutSend.AutoSize = true;
			this.lbAboutSend.Location = new System.Drawing.Point(12, 309);
			this.lbAboutSend.Name = "lbAboutSend";
			this.lbAboutSend.Size = new System.Drawing.Size(92, 13);
			this.lbAboutSend.TabIndex = 12;
			this.lbAboutSend.Text = "Сообщение для: ";
			// 
			// lbForUser
			// 
			this.lbForUser.AutoSize = true;
			this.lbForUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbForUser.Location = new System.Drawing.Point(98, 310);
			this.lbForUser.Name = "lbForUser";
			this.lbForUser.Size = new System.Drawing.Size(21, 13);
			this.lbForUser.TabIndex = 13;
			this.lbForUser.Text = "All";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripChatStatus});
			this.statusStrip1.Location = new System.Drawing.Point(0, 371);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(517, 22);
			this.statusStrip1.TabIndex = 14;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(69, 17);
			this.toolStripStatusLabel1.Text = "Состояние:";
			// 
			// toolStripChatStatus
			// 
			this.toolStripChatStatus.Name = "toolStripChatStatus";
			this.toolStripChatStatus.Size = new System.Drawing.Size(43, 17);
			this.toolStripChatStatus.Text = "Offline";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(517, 393);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.lbForUser);
			this.Controls.Add(this.lbAboutSend);
			this.Controls.Add(this.txtMessage);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.lstUsers);
			this.Controls.Add(this.txtChat);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.mainMenu);
			this.MainMenuStrip = this.mainMenu;
			this.Name = "FormMain";
			this.Text = "Чат";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.mainMenu.ResumeLayout(false);
			this.mainMenu.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem подключитсяToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem отключитсяToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.TextBox txtChat;
		private System.Windows.Forms.ListBox lstUsers;
		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.Label lbAboutSend;
		private System.Windows.Forms.Label lbForUser;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripChatStatus;
	}
}

