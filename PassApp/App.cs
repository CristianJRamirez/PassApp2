using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PassApp
{
    public partial class App : Form
    {
        public Ruta path = new Ruta();
        public Archivo archivo = new Archivo();
        public Datos datos = new Datos();
        public List<string[]> Pass = new List<string[]>();
        private XmlDocument documento;
        public App()
        {
            InitializeComponent();
        }

        private void App_Load(object sender, EventArgs e)
        {
            ControlUsuario CU = new ControlUsuario();
            CU.ShowDialog();
            DesencriptarStr();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            lblCorreo.Visible = lblOther.Visible
                = lblPagApp.Visible = lblPass.Visible = lblUser.Visible = true;
            txtCorreo.Visible = txtOther.Visible = txtPagApp.Visible =
                txtPass.Visible = txtUser.Visible = true;
            btSavePass.Visible = true;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUser.Text)&&!string.IsNullOrWhiteSpace(txtPass.Text))
            {
              InsertarXml();
              txtCorreo.Text = txtOther.Text = txtPagApp.Text =
              txtPass.Text = txtUser.Text = "";
            }
        }

        private void InsertarXml()
        {
            try
            {
                //string ruta = "C:\\Users\\Cristian J\\Desktop\\App\\passwords.xml";
                //Cargamos el documento XML.
                documento = new XmlDocument();
                documento.Load(path.RutaArchivo + "tmp.xml");
                //documento.LoadXml();Carga un archivo string
                //Creamos el nodo que deseamos insertar.
                XmlNode Contraseña = this.CrearNodoXml(txtCorreo.Text , txtOther.Text , txtPagApp.Text , txtPass.Text , txtUser.Text);

                //Obtenemos el nodo raiz del documento.		documento.OuterXml	"<?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\"?><!--Prueba--><Pass><Pass><PaginaApp>facebook</PaginaApp><user>cj2394@hotmail.com</user><password>killzone-23</password><correo>cj2394@hotmail.com</correo><other>facebook: cristian javier ramirez arroyo</other></Pass><Pass><PaginaApp>Apple ICloud</PaginaApp><user>crisj23</user><password>Killzone-23</password><correo>crisj23@icloud.com</correo><other>Apple-ICloud</other></Pass><Pass><PaginaApp>g</PaginaApp><user>g</user><password>g</password><correo>g</correo><other>g</other></Pass><Pass><PaginaApp>f</PaginaApp><user>f</user><password>f</password><correo>f</correo><other>ff</other></Pass><Pass><PaginaApp>q</PaginaApp><user>q</user><password>q</password><correo>q</correo><other>q</other></Pass><Pass><PaginaApp>1</PaginaApp><user>2</user><password>45</password><correo>3</correo><other>5</other></Pass></Pass>"	string

                XmlNode nodoRaiz = documento.DocumentElement;

                //Insertamos el nodo empleado al final del archivo
                nodoRaiz.InsertAfter(Contraseña, nodoRaiz.LastChild);   //***

                documento.Save(path.RutaArchivo + "tmp.xml");
                //documento.OuterXml;te da el string de todo el documento xml
                

                EncriptarStr();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private XmlNode CrearNodoXml(string correo, string other, string pagapp, string pass, string user)
        {
            //Creamos el nodo que deseamos insertar.
            XmlElement Pass = documento.CreateElement("Pass");

            //Creamos el elemento paginaApp.
            XmlElement paginaApp = documento.CreateElement("PaginaApp");
            paginaApp.InnerText = pagapp;
            Pass.AppendChild(paginaApp);

            //Creamos el elemento user.
            XmlElement User = documento.CreateElement("user");
            User.InnerText = user;
            Pass.AppendChild(User);

            //Creamos el elemento password.
            XmlElement password = documento.CreateElement("password");
            password.InnerText = pass;
            Pass.AppendChild(password);

            //Creamos el elemento correo.
            XmlElement Correo = documento.CreateElement("correo");
            Correo.InnerText = correo;
            Pass.AppendChild(Correo);

            //Creamos el elemento other.
            XmlElement Other = documento.CreateElement("other");
            Other.InnerText = other;
            Pass.AppendChild(Other);

            return Pass;
        }

        private void DesencriptarStr()
        {
            String line;
            using (StreamReader sr = new StreamReader(path.RutaCompleta))
            {
                // Read the stream to a string, and write the string to the console.
                line = sr.ReadToEnd();
                sr.Close();
                //MessageBox.Show("-> " + line);
            }
            Escribir(Desencriptar(line));
        }

        private void EncriptarStr()
        {
            String line;
            using (StreamReader sr = new StreamReader(path.RutaArchivo + "tmp.xml"))
            {
                // Read the stream to a string, and write the string to the console.
                line = sr.ReadToEnd();
                sr.Close();
                //MessageBox.Show("-> " + line);
            }
            EscribirEncriptado(Encriptar(line));

        }

        private void Escribir(string str)        {

            //System.IO.File.WriteAllText();//escritura del archivo sin hacer el using
            
            using (StreamWriter sw = new StreamWriter(path.RutaArchivo + "tmp.xml"))
            {
                // Read the stream to a string, and write the string to the console.
                sw.Write(str);
                sw.Close();
                //MessageBox.Show("-> " + line);
            }
        }
        private void EscribirEncriptado(string str)
        {
            //System.IO.File.ReadAllText();//lectura del archivo sin hacer el using
            //System.IO.File.AppendAllText();//añade al archivo sin hacer el using
            using (StreamWriter sw = new StreamWriter(path.RutaCompleta))
            {
                // Read the stream to a string, and write the string to the console.
                sw.Write(str);
                sw.Close();
                //MessageBox.Show("-> " + line);
            }
        }

        private void Leer()
        {
            #region Leer todo el documento
            //String line;
            //using (StreamReader sr = new StreamReader(@"C:\Users\Cristian J\Desktop\App\MyNewFile2.xml"))
            //{
            //    // Read the stream to a string, and write the string to the console.
            //    line = sr.ReadToEnd();
            //    MessageBox.Show("-> " + line);
            //}
            #endregion
            
           // Pass.Add(new string [] {"paginaApp", "user", "password", "correo", "other"});
            XmlTextReader reader = new XmlTextReader(path.RutaArchivo + "tmp.xml");
            string element = string.Empty;
            string elementf = string.Empty;
            string PaginaApp = string.Empty;
            string user = string.Empty;
            string password = string.Empty;
            string correo = string.Empty;
            string other = string.Empty;
            datos.Clear();

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.
                         //MessageBox.Show("<" + reader.Name + ">");
                        element = reader.Name;
                        break;

                    case XmlNodeType.Text: //Display the text in each element.
                        #region Texto
                        if (element == "PaginaApp")
                        {
                            if (string.IsNullOrEmpty(reader.Value)) { PaginaApp = ""; }
                            else { PaginaApp = reader.Value;  }
                        }
                        else if (element == "user")
                        {
                            if (string.IsNullOrEmpty(reader.Value)) { user = ""; }
                            else {user = reader.Value; }
                        }
                        else if (element == "password")
                        {
                            if (string.IsNullOrEmpty(reader.Value)) { password = ""; }
                            else {password = reader.Value; }
                        }
                        else if (element == "correo")
                        {
                            if (string.IsNullOrEmpty(reader.Value)) { correo = ""; }
                            else {correo = reader.Value; }
                        }
                        else if (element == "other")
                        {
                            if (string.IsNullOrEmpty(reader.Value)) { other = ""; }
                            else { other = reader.Value; }
                        }
                        break;
                        #endregion

                    case XmlNodeType.EndElement: //Display the end of the element.
                        //MessageBox.Show("</" + reader.Name+">");
                        if ("</" + reader.Name + ">" == "</" + "Pass" + ">")
                        {
                            //MessageBox.Show("D : " + PaginaApp + '-' + user + '-' + password + '-' + correo + '-' + other);
                            datos.setDatos(PaginaApp, user, password, correo, other);
                            PaginaApp = string.Empty;
                            user = string.Empty;
                            password = string.Empty;
                            correo = string.Empty;
                            other = string.Empty;
                        }
                        break;
                }
            }

            reader.Close();
        }

        private void btView_Click(object sender, EventArgs e)
        {
            lblCorreo.Visible = lblOther.Visible
                    = lblPagApp.Visible = lblPass.Visible = lblUser.Visible = false;
            txtCorreo.Visible = txtOther.Visible = txtPagApp.Visible =
                txtPass.Visible = txtUser.Visible = false;
            btSavePass.Visible = false;
            Leer();
            DataSource DS = new DataSource(datos);
            DS.ShowDialog();
        }
        
        public static string Encriptar(/*this*/ string sValor)
        {
            string sResultado = string.Empty;
            TripleDESCryptoServiceProvider oTripleDESC = new TripleDESCryptoServiceProvider();

            try
            {
                byte[] bIN = Encoding.UTF8.GetBytes(sValor);

                using (MemoryStream oOutStream = new MemoryStream())
                {
                    CryptoStream oCryptoStream =
                        new CryptoStream(oOutStream, oTripleDESC.CreateEncryptor(Vectores.bClave, Vectores.bVector), CryptoStreamMode.Write);

                    oCryptoStream.Write(bIN, 0, bIN.Length);
                    oCryptoStream.FlushFinalBlock();

                    sResultado = Convert.ToBase64String(oOutStream.ToArray());
                    oOutStream.Close();
                    //MessageBox.Show(sResultado);
                }
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message, ex.InnerException);
            }

            return sResultado;
        }
        
        /// <summary>
        /// Descifra un valor encriptado anteriormente con la función Encriptar.
        /// </summary>
        /// <param name="sValor">this string: valor encriptado</param>
        /// <returns>string con el valor</returns>
        [Obsolete]
        public static string Desencriptar(string sValor)
        {
            string sResultado = string.Empty;
            TripleDESCryptoServiceProvider oTripleDESC = new TripleDESCryptoServiceProvider();

            try
            {
                byte[] bIN = Convert.FromBase64String(sValor);

                using (MemoryStream oOutStream = new MemoryStream())
                {
                    CryptoStream oCryptoStream =
                        new CryptoStream(oOutStream, oTripleDESC.CreateDecryptor(Vectores.bClave, Vectores.bVector), CryptoStreamMode.Write);

                    oCryptoStream.Write(bIN, 0, bIN.Length);
                    oCryptoStream.FlushFinalBlock();

                    sResultado = Encoding.UTF8.GetString(oOutStream.ToArray());
                    oOutStream.Close();
                }
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message, ex.InnerException);
            }

            return sResultado;
        }

        private void BorrarTmp()
        {
            System.IO.File.Delete(path.RutaArchivo + "tmp.xml");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EncriptarStr();
            BorrarTmp();
            this.Close();
        }
    }
}
