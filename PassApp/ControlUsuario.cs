using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassApp
{
    public partial class ControlUsuario : Form
    {
        private string user ="cristian";
        private string pass = "1234";
        public ControlUsuario()
        {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            bool ok = true;
            do {
                if (!string.IsNullOrWhiteSpace(txtUserControl.Text) && (!string.IsNullOrWhiteSpace(txtPassControl.Text)))
                {
                    if ((txtUserControl.Text == user) && (txtPassControl.Text == pass))
                    {
                        //MessageBox.Show("Correcto!");
                        ok = false;
                    }
                    else
                    {
                        MessageBox.Show("Error en el Usuario o Contraseña");
                        txtPassControl.Text = string.Empty;
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Error en el Usuario o Contraseña");
                    txtPassControl.Text = string.Empty;
                    return;
                }
             } while (ok);
             this.Close(); 
        }

        private void ControlUsuario_Load(object sender, EventArgs e)
        {
            txtUserControl.Text = user;
        }
    }
}
