using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlv2
{
    public partial class ControlUsuario : Form
    {
        private string user ="cristian";
        private string pass = "1234";
        public static bool acceso ;

        public ControlUsuario()
        {
            InitializeComponent();
        }


        private void btOK_Click(object sender, EventArgs e)
        {
            comprovarDatos();
            

        }

        private void comprovarDatos()
        {
            bool ok = true;
           /* do
            {*/
                if (!string.IsNullOrWhiteSpace(txtUserControl.Text) && (!string.IsNullOrWhiteSpace(txtPassControl.Text)))
                {
                    if ((txtUserControl.Text == user) && (txtPassControl.Text == pass))
                    {
                        //MessageBox.Show("Correcto!");
                        ok = false;
                        acceso = true;
                    }
                    else
                    {
                        MessageBox.Show("Error en el Usuario o Contraseña");
                        txtPassControl.Text = string.Empty;
                        acceso =false;
                    }
                }
                else
                {
                    MessageBox.Show("Error en el Usuario o Contraseña");
                    txtPassControl.Text = string.Empty;
                    acceso= false;
                }
           // } while (ok);
            this.Close();
        }

        private void ControlUsuario_Load(object sender, EventArgs e)
        {
            txtUserControl.Text = user;
        }
        public static bool getAcceso()
        {
            return acceso;
        }
    }
}
