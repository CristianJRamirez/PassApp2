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
    public partial class DataSource : Form
    {
        private Datos Datos = new Datos();
        private ListViewItem listViewItem1;
        public DataSource(Datos datos)
        {
            InitializeComponent();
            Datos = datos;
        }

        private void DataSource_Load(object sender, EventArgs e)
        {
            list.Items.Clear();
            foreach (var item in Datos.getDatos())
            {
                listViewItem1 = new ListViewItem(new string[] { item[0].ToString(), item[1].ToString(), item[2].ToString(), item[3].ToString(), item[4].ToString() }, -1);
                list.Items.Add(listViewItem1);
            }
        }
    }
}
