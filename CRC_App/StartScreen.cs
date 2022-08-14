/// <author>
/// Kayra POLAT
/// </author>

using System;
using System.Windows.Forms;

namespace CRC_App
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        #region Move Main Screen
        private void btn_encode_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
        #endregion

        #region Exit Program
        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion
    }
}
