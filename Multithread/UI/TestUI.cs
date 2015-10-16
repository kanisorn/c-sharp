using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multithread.UI
{
    public partial class TestUI : Form
    {
        public TestUI()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Processing....";
            //ShowOutputFromSlowProcess();
            lblStatus.Text = "sleeping....";
            Thread slowThread = new Thread(new ThreadStart(ShowOutputFromSlowProcess));
            slowThread.Start();
            //lblStatus.Text = "Finished....";
            
        }

        delegate void SetTextCallback(string text);
        private void ShowOutputFromSlowProcess()
        {
            Thread.Sleep(10000);
            MessageBox.Show("done");
            //string text = "";
            //for (int i = 0; i < 100; i++)
            //{
            //    text += ((char)(10) + (char)(13) + i);
            //}

            //SetText(text);
        }

        private void SetText(string text)
        {
            if (this.txtResult.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtResult.Text = text;
            }

            lblStatus.Text = "sleeping....";
            Thread.Sleep(100000);
            lblStatus.Text = "Finished....";
        }
        private void btnClickFast_Click(object sender, EventArgs e)
        {
            lblResult2.Text = "";
            for (int i = 0; i < 100; i++)
            {
                lblResult2.Text += ((char)(10) + (char)(13) + i);
            }
            
        }

        private void TestUI_Load(object sender, EventArgs e)
        {
            
        }
    }
}
