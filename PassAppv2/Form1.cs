using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PassApp;



namespace PassAppv2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

           // UserControl.ControlUser cr = UserControl.ControlUser();

            
            ControlUsuario CU = new ControlUsuario();
            CU.ShowDialog();

        }
    }
}
