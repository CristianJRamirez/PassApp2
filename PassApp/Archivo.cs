using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassApp
{
    public class Archivo
    {
        private string xml = string.Empty;
        private Byte[] xmlByte;
        public string getstrArchivo()
        {
            return xml;
        }
        public Byte[] getArchivo()
        {
            return xmlByte;
        }
        public void setstrArchivo(string lectura)
        {
            xml = lectura;
        }
        public void setArchivo(Byte []strbyte)
        {
            xmlByte = strbyte;
        }
    }
}
