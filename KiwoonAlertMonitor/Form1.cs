using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiwoonAlertMonitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var handle = WinAppServices.FindSubHandle(HtsControls.가장매매);
            if (handle > 0)
            {
                WinAppServices.SendOrder((IntPtr)handle);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var handle = WinAppServices.FindSubHandle(HtsControls.주문거부);
            if (handle > 0)
            {
                WinAppServices.SendOrder((IntPtr)handle);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var handle = WinAppServices.FindSubHandle(HtsControls.일괄주문);
            if (handle > 0)
            {
                WinAppServices.SendOrder((IntPtr)handle);
            }
        }
    }
}
