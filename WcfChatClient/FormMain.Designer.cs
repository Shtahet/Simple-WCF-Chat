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
			this.опцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.адрессСервисаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.mainMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(25, 52);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(218, 20);
			this.txtUserName.TabIndex = 2;
			// 
			// mainMenu
			// 
			this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.опцииToolStripMenuItem});
			this.mainMenu.Location = new System.Drawing.Point(0, 0);
			this.mainMenu.Name = "mainMenu";
			this.mainMenu.Size = new System.Drawing.Size(549, 24);
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
			this.подключитсяToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.подключитсяToolStripMenuItem.Text = "Подключится";
			// 
			// отключитсяToolStripMenuItem
			// 
			this.отключитсяToolStripMenuItem.Name = "отключитсяToolStripMenuItem";
			this.отключитсяToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.отключитсяToolStripMenuItem.Text = "Отключится";
			// 
			// опцииToolStripMenuItem
			// 
			this.опцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem});
			this.опцииToolStripMenuItem.Name = "опцииToolStripMenuItem";
			this.опцииToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.опцииToolStripMenuItem.Text = "Опции";
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.выходToolStripMenuItem.Text = "Выход";
			// 
			// настройкиToolStripMenuItem
			// 
			this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.адрессСервисаToolStripMenuItem,
            this.toolStripTextBox1});
			this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
			this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.настройкиToolStripMenuItem.Text = "Настройки";
			// 
			// адрессСервисаToolStripMenuItem
			// 
			this.адрессСервисаToolStripMenuItem.Name = "адрессСервисаToolStripMenuItem";
			this.адрессСервисаToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.адрессСервисаToolStripMenuItem.Text = "Адресс сервиса:";
			// 
			// toolStripTextBox1
			// 
			this.toolStripTextBox1.Name = "toolStripTextBox1";
			this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(549, 297);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.mainMenu);
			this.MainMenuStrip = this.mainMenu;
			this.Name = "FormMain";
			this.Text = "Чат";
			this.mainMenu.ResumeLayout(false);
			this.mainMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem подключитсяToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem отключитсяToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem опцииToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem адрессСервисаToolStripMenuItem;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
	}
}

