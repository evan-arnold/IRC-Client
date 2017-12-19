namespace SZIrc
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.RichTextBox_Chat = new System.Windows.Forms.RichTextBox();
            this.Button_Connection = new System.Windows.Forms.Button();
            this.TextBox_Message = new System.Windows.Forms.TextBox();
            this.ToolStrip_Main = new System.Windows.Forms.ToolStrip();
            this.ToolStrip_Main_Tools = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStrip_Main_Tools_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Main_Tools_RAW = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Main_Tools_Seperator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStrip_Main_Tools_Button_Dark = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Main_Tools_Button_Light = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Main_Tools_Seperator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStrip_Main_DropButton_Theme_Button_AlertColor = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBox_AlertColor = new System.Windows.Forms.ToolStripTextBox();
            this.ToolStrip_Main_DropButton_Theme_Button_CommandColor = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBox_CommandColor = new System.Windows.Forms.ToolStripTextBox();
            this.ToolStrip_Main_DropButton_Theme_Button_MessageColor = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBox_MessageColor = new System.Windows.Forms.ToolStripTextBox();
            this.ToolStrip_Main_DropButton_Theme_Button_PMColor = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBox_PMColor = new System.Windows.Forms.ToolStripTextBox();
            this.ToolStrip_Main_Tools_Seperator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStrip_Main_Tools_SaveLog = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Main_Button_Website = new System.Windows.Forms.ToolStripButton();
            this.CheckBox_Command = new System.Windows.Forms.CheckBox();
            this.Button_Send = new System.Windows.Forms.Button();
            this.ListBox_Users = new System.Windows.Forms.ListBox();
            this.GroupBox_Users = new System.Windows.Forms.GroupBox();
            this.ToolStrip_Main.SuspendLayout();
            this.GroupBox_Users.SuspendLayout();
            this.SuspendLayout();
            // 
            // RichTextBox_Chat
            // 
            this.RichTextBox_Chat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTextBox_Chat.BackColor = System.Drawing.Color.Black;
            this.RichTextBox_Chat.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RichTextBox_Chat.ForeColor = System.Drawing.Color.White;
            this.RichTextBox_Chat.Location = new System.Drawing.Point(3, 28);
            this.RichTextBox_Chat.Name = "RichTextBox_Chat";
            this.RichTextBox_Chat.ReadOnly = true;
            this.RichTextBox_Chat.Size = new System.Drawing.Size(647, 322);
            this.RichTextBox_Chat.TabIndex = 3;
            this.RichTextBox_Chat.Text = "[!] is an alert\n[C] is a command that was sent\n[M] is a message\n[PM] is a private" +
    " message\n";
            this.RichTextBox_Chat.TextChanged += new System.EventHandler(this.RichTextBox_Chat_TextChanged);
            // 
            // Button_Connection
            // 
            this.Button_Connection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Connection.Location = new System.Drawing.Point(577, 352);
            this.Button_Connection.Name = "Button_Connection";
            this.Button_Connection.Size = new System.Drawing.Size(73, 23);
            this.Button_Connection.TabIndex = 4;
            this.Button_Connection.Text = "Connect";
            this.Button_Connection.UseVisualStyleBackColor = true;
            this.Button_Connection.Click += new System.EventHandler(this.Button_Connection_Click);
            // 
            // TextBox_Message
            // 
            this.TextBox_Message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_Message.BackColor = System.Drawing.Color.White;
            this.TextBox_Message.ForeColor = System.Drawing.Color.Black;
            this.TextBox_Message.Location = new System.Drawing.Point(40, 354);
            this.TextBox_Message.Name = "TextBox_Message";
            this.TextBox_Message.Size = new System.Drawing.Size(471, 20);
            this.TextBox_Message.TabIndex = 5;
            this.TextBox_Message.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Message_KeyPress);
            // 
            // ToolStrip_Main
            // 
            this.ToolStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStrip_Main_Tools,
            this.ToolStrip_Main_Button_Website});
            this.ToolStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip_Main.Name = "ToolStrip_Main";
            this.ToolStrip_Main.Size = new System.Drawing.Size(828, 25);
            this.ToolStrip_Main.TabIndex = 6;
            // 
            // ToolStrip_Main_Tools
            // 
            this.ToolStrip_Main_Tools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStrip_Main_Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStrip_Main_Tools_Settings,
            this.ToolStrip_Main_Tools_RAW,
            this.ToolStrip_Main_Tools_Seperator1,
            this.ToolStrip_Main_Tools_Button_Dark,
            this.ToolStrip_Main_Tools_Button_Light,
            this.ToolStrip_Main_Tools_Seperator2,
            this.ToolStrip_Main_DropButton_Theme_Button_AlertColor,
            this.ToolStrip_Main_DropButton_Theme_Button_CommandColor,
            this.ToolStrip_Main_DropButton_Theme_Button_MessageColor,
            this.ToolStrip_Main_DropButton_Theme_Button_PMColor,
            this.ToolStrip_Main_Tools_Seperator3,
            this.ToolStrip_Main_Tools_SaveLog});
            this.ToolStrip_Main_Tools.Image = ((System.Drawing.Image)(resources.GetObject("ToolStrip_Main_Tools.Image")));
            this.ToolStrip_Main_Tools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStrip_Main_Tools.Name = "ToolStrip_Main_Tools";
            this.ToolStrip_Main_Tools.Size = new System.Drawing.Size(29, 22);
            this.ToolStrip_Main_Tools.Text = "Tools";
            // 
            // ToolStrip_Main_Tools_Settings
            // 
            this.ToolStrip_Main_Tools_Settings.Name = "ToolStrip_Main_Tools_Settings";
            this.ToolStrip_Main_Tools_Settings.Size = new System.Drawing.Size(163, 22);
            this.ToolStrip_Main_Tools_Settings.Text = "Settings";
            this.ToolStrip_Main_Tools_Settings.Click += new System.EventHandler(this.ToolStrip_Main_Tools_Settings_Click);
            // 
            // ToolStrip_Main_Tools_RAW
            // 
            this.ToolStrip_Main_Tools_RAW.Name = "ToolStrip_Main_Tools_RAW";
            this.ToolStrip_Main_Tools_RAW.Size = new System.Drawing.Size(163, 22);
            this.ToolStrip_Main_Tools_RAW.Text = "RAW Data";
            this.ToolStrip_Main_Tools_RAW.Click += new System.EventHandler(this.ToolStrip_Main_Tools_RAW_Click);
            // 
            // ToolStrip_Main_Tools_Seperator1
            // 
            this.ToolStrip_Main_Tools_Seperator1.Name = "ToolStrip_Main_Tools_Seperator1";
            this.ToolStrip_Main_Tools_Seperator1.Size = new System.Drawing.Size(160, 6);
            // 
            // ToolStrip_Main_Tools_Button_Dark
            // 
            this.ToolStrip_Main_Tools_Button_Dark.Name = "ToolStrip_Main_Tools_Button_Dark";
            this.ToolStrip_Main_Tools_Button_Dark.Size = new System.Drawing.Size(163, 22);
            this.ToolStrip_Main_Tools_Button_Dark.Text = "• Dark";
            this.ToolStrip_Main_Tools_Button_Dark.Click += new System.EventHandler(this.ToolStripButton_Dark_Click);
            // 
            // ToolStrip_Main_Tools_Button_Light
            // 
            this.ToolStrip_Main_Tools_Button_Light.Name = "ToolStrip_Main_Tools_Button_Light";
            this.ToolStrip_Main_Tools_Button_Light.Size = new System.Drawing.Size(163, 22);
            this.ToolStrip_Main_Tools_Button_Light.Text = "Light";
            this.ToolStrip_Main_Tools_Button_Light.Click += new System.EventHandler(this.ToolStripButton_Light_Click);
            // 
            // ToolStrip_Main_Tools_Seperator2
            // 
            this.ToolStrip_Main_Tools_Seperator2.Name = "ToolStrip_Main_Tools_Seperator2";
            this.ToolStrip_Main_Tools_Seperator2.Size = new System.Drawing.Size(160, 6);
            // 
            // ToolStrip_Main_DropButton_Theme_Button_AlertColor
            // 
            this.ToolStrip_Main_DropButton_Theme_Button_AlertColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TextBox_AlertColor});
            this.ToolStrip_Main_DropButton_Theme_Button_AlertColor.Name = "ToolStrip_Main_DropButton_Theme_Button_AlertColor";
            this.ToolStrip_Main_DropButton_Theme_Button_AlertColor.Size = new System.Drawing.Size(163, 22);
            this.ToolStrip_Main_DropButton_Theme_Button_AlertColor.Text = "Alert Color";
            this.ToolStrip_Main_DropButton_Theme_Button_AlertColor.DropDownClosed += new System.EventHandler(this.ToolStrip_AlertColor_DropDownClosed);
            // 
            // TextBox_AlertColor
            // 
            this.TextBox_AlertColor.Name = "TextBox_AlertColor";
            this.TextBox_AlertColor.Size = new System.Drawing.Size(100, 23);
            this.TextBox_AlertColor.Text = "#FF0000";
            // 
            // ToolStrip_Main_DropButton_Theme_Button_CommandColor
            // 
            this.ToolStrip_Main_DropButton_Theme_Button_CommandColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TextBox_CommandColor});
            this.ToolStrip_Main_DropButton_Theme_Button_CommandColor.Name = "ToolStrip_Main_DropButton_Theme_Button_CommandColor";
            this.ToolStrip_Main_DropButton_Theme_Button_CommandColor.Size = new System.Drawing.Size(163, 22);
            this.ToolStrip_Main_DropButton_Theme_Button_CommandColor.Text = "Command Color";
            this.ToolStrip_Main_DropButton_Theme_Button_CommandColor.DropDownClosed += new System.EventHandler(this.ToolStrip_Main_DropButton_Theme_Button_CommandColor_DropDownClosed);
            // 
            // TextBox_CommandColor
            // 
            this.TextBox_CommandColor.Name = "TextBox_CommandColor";
            this.TextBox_CommandColor.Size = new System.Drawing.Size(100, 23);
            this.TextBox_CommandColor.Text = "#00FF15";
            // 
            // ToolStrip_Main_DropButton_Theme_Button_MessageColor
            // 
            this.ToolStrip_Main_DropButton_Theme_Button_MessageColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TextBox_MessageColor});
            this.ToolStrip_Main_DropButton_Theme_Button_MessageColor.Name = "ToolStrip_Main_DropButton_Theme_Button_MessageColor";
            this.ToolStrip_Main_DropButton_Theme_Button_MessageColor.Size = new System.Drawing.Size(163, 22);
            this.ToolStrip_Main_DropButton_Theme_Button_MessageColor.Text = "Message Color";
            this.ToolStrip_Main_DropButton_Theme_Button_MessageColor.DropDownClosed += new System.EventHandler(this.ToolStrip_Main_DropButton_Theme_Button_MessageColor_DropDownClosed);
            // 
            // TextBox_MessageColor
            // 
            this.TextBox_MessageColor.Name = "TextBox_MessageColor";
            this.TextBox_MessageColor.Size = new System.Drawing.Size(100, 23);
            this.TextBox_MessageColor.Text = "#00BFFF";
            // 
            // ToolStrip_Main_DropButton_Theme_Button_PMColor
            // 
            this.ToolStrip_Main_DropButton_Theme_Button_PMColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TextBox_PMColor});
            this.ToolStrip_Main_DropButton_Theme_Button_PMColor.Name = "ToolStrip_Main_DropButton_Theme_Button_PMColor";
            this.ToolStrip_Main_DropButton_Theme_Button_PMColor.Size = new System.Drawing.Size(163, 22);
            this.ToolStrip_Main_DropButton_Theme_Button_PMColor.Text = "PM Color";
            this.ToolStrip_Main_DropButton_Theme_Button_PMColor.DropDownClosed += new System.EventHandler(this.ToolStrip_Main_DropButton_Theme_Button_PMColor_DropDownClosed);
            // 
            // TextBox_PMColor
            // 
            this.TextBox_PMColor.Name = "TextBox_PMColor";
            this.TextBox_PMColor.Size = new System.Drawing.Size(100, 23);
            this.TextBox_PMColor.Text = "#FFBB00";
            // 
            // ToolStrip_Main_Tools_Seperator3
            // 
            this.ToolStrip_Main_Tools_Seperator3.Name = "ToolStrip_Main_Tools_Seperator3";
            this.ToolStrip_Main_Tools_Seperator3.Size = new System.Drawing.Size(160, 6);
            // 
            // ToolStrip_Main_Tools_SaveLog
            // 
            this.ToolStrip_Main_Tools_SaveLog.Name = "ToolStrip_Main_Tools_SaveLog";
            this.ToolStrip_Main_Tools_SaveLog.Size = new System.Drawing.Size(163, 22);
            this.ToolStrip_Main_Tools_SaveLog.Text = "Save Log";
            this.ToolStrip_Main_Tools_SaveLog.Click += new System.EventHandler(this.ToolStrip_Main_Tools_SaveLog_Click);
            // 
            // ToolStrip_Main_Button_Website
            // 
            this.ToolStrip_Main_Button_Website.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStrip_Main_Button_Website.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStrip_Main_Button_Website.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStrip_Main_Button_Website.Name = "ToolStrip_Main_Button_Website";
            this.ToolStrip_Main_Button_Website.Size = new System.Drawing.Size(53, 22);
            this.ToolStrip_Main_Button_Website.Text = "Website";
            // 
            // CheckBox_Command
            // 
            this.CheckBox_Command.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CheckBox_Command.AutoSize = true;
            this.CheckBox_Command.Location = new System.Drawing.Point(3, 356);
            this.CheckBox_Command.Name = "CheckBox_Command";
            this.CheckBox_Command.Size = new System.Drawing.Size(31, 17);
            this.CheckBox_Command.TabIndex = 7;
            this.CheckBox_Command.Text = "/";
            this.CheckBox_Command.UseVisualStyleBackColor = true;
            // 
            // Button_Send
            // 
            this.Button_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Send.Enabled = false;
            this.Button_Send.Location = new System.Drawing.Point(517, 352);
            this.Button_Send.Name = "Button_Send";
            this.Button_Send.Size = new System.Drawing.Size(57, 23);
            this.Button_Send.TabIndex = 8;
            this.Button_Send.Text = "Send";
            this.Button_Send.UseVisualStyleBackColor = true;
            this.Button_Send.Click += new System.EventHandler(this.Button_Send_Click);
            // 
            // ListBox_Users
            // 
            this.ListBox_Users.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBox_Users.BackColor = System.Drawing.Color.Black;
            this.ListBox_Users.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBox_Users.ForeColor = System.Drawing.Color.White;
            this.ListBox_Users.FormattingEnabled = true;
            this.ListBox_Users.Location = new System.Drawing.Point(7, 17);
            this.ListBox_Users.Name = "ListBox_Users";
            this.ListBox_Users.Size = new System.Drawing.Size(152, 325);
            this.ListBox_Users.TabIndex = 9;
            // 
            // GroupBox_Users
            // 
            this.GroupBox_Users.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_Users.Controls.Add(this.ListBox_Users);
            this.GroupBox_Users.Location = new System.Drawing.Point(656, 26);
            this.GroupBox_Users.Name = "GroupBox_Users";
            this.GroupBox_Users.Size = new System.Drawing.Size(166, 349);
            this.GroupBox_Users.TabIndex = 10;
            this.GroupBox_Users.TabStop = false;
            this.GroupBox_Users.Text = "Users";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 379);
            this.Controls.Add(this.GroupBox_Users);
            this.Controls.Add(this.Button_Send);
            this.Controls.Add(this.CheckBox_Command);
            this.Controls.Add(this.ToolStrip_Main);
            this.Controls.Add(this.TextBox_Message);
            this.Controls.Add(this.Button_Connection);
            this.Controls.Add(this.RichTextBox_Chat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(629, 384);
            this.Name = "Form_Main";
            this.ShowIcon = false;
            this.Text = "SZIrc - Private Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ToolStrip_Main.ResumeLayout(false);
            this.ToolStrip_Main.PerformLayout();
            this.GroupBox_Users.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RichTextBox_Chat;
        private System.Windows.Forms.Button Button_Connection;
        private System.Windows.Forms.TextBox TextBox_Message;
        private System.Windows.Forms.ToolStrip ToolStrip_Main;
        private System.Windows.Forms.CheckBox CheckBox_Command;
        private System.Windows.Forms.Button Button_Send;
        private System.Windows.Forms.ToolStripDropDownButton ToolStrip_Main_Tools;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Main_Tools_Button_Dark;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Main_Tools_Button_Light;
        private System.Windows.Forms.ToolStripSeparator ToolStrip_Main_Tools_Seperator2;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Main_DropButton_Theme_Button_AlertColor;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Main_DropButton_Theme_Button_CommandColor;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Main_DropButton_Theme_Button_MessageColor;
        private System.Windows.Forms.ToolStripTextBox TextBox_AlertColor;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Main_DropButton_Theme_Button_PMColor;
        private System.Windows.Forms.ToolStripTextBox TextBox_CommandColor;
        private System.Windows.Forms.ToolStripTextBox TextBox_MessageColor;
        private System.Windows.Forms.ToolStripTextBox TextBox_PMColor;
        private System.Windows.Forms.ToolStripButton ToolStrip_Main_Button_Website;
        private System.Windows.Forms.ToolStripSeparator ToolStrip_Main_Tools_Seperator3;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Main_Tools_SaveLog;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Main_Tools_Settings;
        private System.Windows.Forms.ToolStripSeparator ToolStrip_Main_Tools_Seperator1;
        private System.Windows.Forms.ListBox ListBox_Users;
        private System.Windows.Forms.GroupBox GroupBox_Users;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Main_Tools_RAW;
    }
}

