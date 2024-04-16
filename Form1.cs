using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Version/0.4
namespace place22
{
    public partial class Form1 : Form
    {
        static int zzz = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)   
        {                                                     
            textBox1.Text = zzz.ToString();
            zzz += 1;
                                                                                           
        }                                                      
    }
}
