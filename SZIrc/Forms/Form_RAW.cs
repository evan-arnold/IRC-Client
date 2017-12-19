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
    public partial class Form_RAW : Form
    {
        public Form_RAW()
        {
            InitializeComponent();
        }

        public void AddToRaw(string String)
        {
            RichTextBox_Data.Text = RichTextBox_Data.Text + Environment.NewLine + String;
        }
    }
}
