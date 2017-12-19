namespace SZIrc.Forms
{
    partial class Form_RAW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_RAW));
            this.RichTextBox_Data = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // RichTextBox_Data
            // 
            this.RichTextBox_Data.AccessibleName = "RichTextBox_Data";
            this.RichTextBox_Data.BackColor = System.Drawing.Color.Black;
            this.RichTextBox_Data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBox_Data.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RichTextBox_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBox_Data.ForeColor = System.Drawing.Color.White;
            this.RichTextBox_Data.Location = new System.Drawing.Point(0, 0);
            this.RichTextBox_Data.Name = "RichTextBox_Data";
            this.RichTextBox_Data.ReadOnly = true;
            this.RichTextBox_Data.Size = new System.Drawing.Size(459, 282);
            this.RichTextBox_Data.TabIndex = 0;
            this.RichTextBox_Data.Text = "Not yet functional.";
            // 
            // Form_RAW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 282);
            this.Controls.Add(this.RichTextBox_Data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_RAW";
            this.ShowIcon = false;
            this.Text = "Raw Data";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RichTextBox_Data;
    }
}