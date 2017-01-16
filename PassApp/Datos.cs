using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassApp
{
    public class Datos
    {
        private List<string> PaginaApp = new List<string>();
        private List<string> User = new List<string>();
        private List<string> Password = new List<string>();
        private List<string> Correo = new List<string>();
        private List<string> Other = new List<string>();
        private List<String[]> datos = new List<string[]>(); 

        //datos.Add(new string[] { "paginaApp", "user", "password", "correo", "other" });
        public List<String[]> getDatos()
        {
            return datos;
        }
        public void setDatos(string paginaApp,string user,string password,string correo,string other)
        {
            datos.Add(new string[] { paginaApp, user, password, correo, other});
            PaginaApp.Add(paginaApp);
            User.Add(user);
            Password.Add(password);
            Correo.Add(correo);
            Other.Add(other);
        }

        public void Clear()
        {
            datos.Clear();
        }

        /*public List<String> getPagina() { return PaginaApp; }
        public List<String> getUser() { return User; }
        public List<String> getPassword() { return Password; }
        public List<String> getCorreo() { return Correo; }
        public List<String> getOther() { return Other; }*/
        

    }
}
