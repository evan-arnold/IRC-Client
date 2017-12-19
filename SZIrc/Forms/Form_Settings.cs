using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SZIrc.Forms
{
    public partial class Form_Settings : Form
    {
        public Form_Settings()
        {
            InitializeComponent();
        }

        private void Button_Accept_Click(object sender, EventArgs e)
        {
            if (TextBox_Nick.Text == string.Empty || TextBox_Name.Text == string.Empty ||
               TextBox_Server.Text == string.Empty || TextBox_Port.Text == string.Empty ||
               TextBox_Channel.Text == string.Empty)
            {
                MessageBox.Show("Make sure all fields are filled out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Variables.Nick = TextBox_Nick.Text;
                Variables.Name = TextBox_Name.Text;
                Variables.Server = TextBox_Server.Text;
                Variables.Port = int.Parse(TextBox_Port.Text);
                Variables.Channel = TextBox_Channel.Text;
                this.Close();
            }
        }

        private void Form_Settings_Load(object sender, EventArgs e)
        {
            TextBox_Nick.Text = Variables.Nick;
            TextBox_Name.Text = Variables.Name;
            TextBox_Server.Text = Variables.Server;
            TextBox_Channel.Text = Variables.Channel;
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox_Port_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)) { } else { e.Handled = e.KeyChar != (char)Keys.Back; }
        }
    }
}
