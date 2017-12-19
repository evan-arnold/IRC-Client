namespace SZIrc.Forms
{
    partial class Form_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Settings));
            this.TextBox_Channel = new System.Windows.Forms.TextBox();
            this.Label_Channel = new System.Windows.Forms.Label();
            this.TextBox_Port = new System.Windows.Forms.TextBox();
            this.Label_Port = new System.Windows.Forms.Label();
            this.TextBox_Server = new System.Windows.Forms.TextBox();
            this.Label_Server = new System.Windows.Forms.Label();
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.Label_Name = new System.Windows.Forms.Label();
            this.TextBox_Nick = new System.Windows.Forms.TextBox();
            this.Label_Nick = new System.Windows.Forms.Label();
            this.Button_Accept = new System.Windows.Forms.Button();
            this.Button_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox_Channel
            // 
            this.TextBox_Channel.BackColor = System.Drawing.Color.White;
            this.TextBox_Channel.ForeColor = System.Drawing.Color.Black;
            this.TextBox_Channel.Location = new System.Drawing.Point(66, 105);
            this.TextBox_Channel.Name = "TextBox_Channel";
            this.TextBox_Channel.Size = new System.Drawing.Size(132, 20);
            this.TextBox_Channel.TabIndex = 19;
            this.TextBox_Channel.Text = "#";
            // 
            // Label_Channel
            // 
            this.Label_Channel.AutoSize = true;
            this.Label_Channel.Location = new System.Drawing.Point(11, 108);
            this.Label_Channel.Name = "Label_Channel";
            this.Label_Channel.Size = new System.Drawing.Size(49, 13);
            this.Label_Channel.TabIndex = 18;
            this.Label_Channel.Text = "Channel:";
            // 
            // TextBox_Port
            // 
            this.TextBox_Port.BackColor = System.Drawing.Color.White;
            this.TextBox_Port.ForeColor = System.Drawing.Color.Black;
            this.TextBox_Port.Location = new System.Drawing.Point(46, 80);
            this.TextBox_Port.Name = "TextBox_Port";
            this.TextBox_Port.Size = new System.Drawing.Size(152, 20);
            this.TextBox_Port.TabIndex = 17;
            this.TextBox_Port.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Port_KeyPress);
            // 
            // Label_Port
            // 
            this.Label_Port.AutoSize = true;
            this.Label_Port.Location = new System.Drawing.Point(11, 83);
            this.Label_Port.Name = "Label_Port";
            this.Label_Port.Size = new System.Drawing.Size(29, 13);
            this.Label_Port.TabIndex = 16;
            this.Label_Port.Text = "Port:";
            // 
            // TextBox_Server
            // 
            this.TextBox_Server.BackColor = System.Drawing.Color.White;
            this.TextBox_Server.ForeColor = System.Drawing.Color.Black;
            this.TextBox_Server.Location = new System.Drawing.Point(58, 56);
            this.TextBox_Server.Name = "TextBox_Server";
            this.TextBox_Server.Size = new System.Drawing.Size(140, 20);
            this.TextBox_Server.TabIndex = 15;
            // 
            // Label_Server
            // 
            this.Label_Server.AutoSize = true;
            this.Label_Server.Location = new System.Drawing.Point(11, 59);
            this.Label_Server.Name = "Label_Server";
            this.Label_Server.Size = new System.Drawing.Size(41, 13);
            this.Label_Server.TabIndex = 14;
            this.Label_Server.Text = "Server:";
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.BackColor = System.Drawing.Color.White;
            this.TextBox_Name.ForeColor = System.Drawing.Color.Black;
            this.TextBox_Name.Location = new System.Drawing.Point(49, 32);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(149, 20);
            this.TextBox_Name.TabIndex = 13;
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Location = new System.Drawing.Point(11, 35);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(38, 13);
            this.Label_Name.TabIndex = 12;
            this.Label_Name.Text = "Name:";
            // 
            // TextBox_Nick
            // 
            this.TextBox_Nick.BackColor = System.Drawing.Color.White;
            this.TextBox_Nick.ForeColor = System.Drawing.Color.Black;
            this.TextBox_Nick.Location = new System.Drawing.Point(49, 8);
            this.TextBox_Nick.Name = "TextBox_Nick";
            this.TextBox_Nick.Size = new System.Drawing.Size(149, 20);
            this.TextBox_Nick.TabIndex = 11;
            // 
            // Label_Nick
            // 
            this.Label_Nick.AutoSize = true;
            this.Label_Nick.Location = new System.Drawing.Point(11, 11);
            this.Label_Nick.Name = "Label_Nick";
            this.Label_Nick.Size = new System.Drawing.Size(32, 13);
            this.Label_Nick.TabIndex = 10;
            this.Label_Nick.Text = "Nick:";
            // 
            // Button_Accept
            // 
            this.Button_Accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Accept.Location = new System.Drawing.Point(-1, 130);
            this.Button_Accept.Name = "Button_Accept";
            this.Button_Accept.Size = new System.Drawing.Size(211, 23);
            this.Button_Accept.TabIndex = 20;
            this.Button_Accept.Text = "Accept";
            this.Button_Accept.UseVisualStyleBackColor = true;
            this.Button_Accept.Click += new System.EventHandler(this.Button_Accept_Click);
            // 
            // Button_Close
            // 
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Close.Location = new System.Drawing.Point(-1, 152);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(211, 23);
            this.Button_Close.TabIndex = 21;
            this.Button_Close.Text = "Close";
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // Form_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 174);
            this.ControlBox = false;
            this.Controls.Add(this.Button_Close);
            this.Controls.Add(this.Button_Accept);
            this.Controls.Add(this.TextBox_Channel);
            this.Controls.Add(this.Label_Channel);
            this.Controls.Add(this.TextBox_Port);
            this.Controls.Add(this.Label_Port);
            this.Controls.Add(this.TextBox_Server);
            this.Controls.Add(this.Label_Server);
            this.Controls.Add(this.TextBox_Name);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.TextBox_Nick);
            this.Controls.Add(this.Label_Nick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "SZIrc - Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Channel;
        private System.Windows.Forms.Label Label_Channel;
        private System.Windows.Forms.TextBox TextBox_Port;
        private System.Windows.Forms.Label Label_Port;
        private System.Windows.Forms.TextBox TextBox_Server;
        private System.Windows.Forms.Label Label_Server;
        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.TextBox TextBox_Nick;
        private System.Windows.Forms.Label Label_Nick;
        private System.Windows.Forms.Button Button_Accept;
        private System.Windows.Forms.Button Button_Close;
    }
}