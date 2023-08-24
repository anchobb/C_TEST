using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_KYS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

  
        private void Conn_btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.PortNumber.Items[this.PortNumber.SelectedIndex].ToString() + " CONN");
            this.msgArea.Text = "";
            this.msgArea.AppendText(this.PortNumber.Items[this.PortNumber.SelectedIndex].ToString() + " CONN");
        }

        private void On_btn_01_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.On_btn_01.Text + " CLICKED");
            this.msgArea.Text = "";
            this.msgArea.AppendText(this.On_btn_01.Text + " SUCCESS");
        }

        private void Off_btn_01_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.Off_btn_01.Text + " CLICKED");
            this.msgArea.Text = "";
            this.msgArea.AppendText(this.Off_btn_01.Text + " SUCCESS");
        }

        private void On_btn_02_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.On_btn_02.Text + " CLICKED");
            this.msgArea.Text = "";
            this.msgArea.AppendText(this.On_btn_02.Text + " SUCCESS");
        }

        private void Off_btn_02_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.Off_btn_02.Text + " CLICKED");
            this.msgArea.Text = "";
            this.msgArea.AppendText(this.Off_btn_02.Text + " SUCCESS");

        }
    }
}
