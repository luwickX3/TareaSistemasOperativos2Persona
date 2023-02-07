using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaSistemasOperativos2Persona
{
    public class Persona
    {
        protected string nombre;
        protected string appPaterno;
        protected string appMaterno;
        protected string fechaNacimiento;
        protected string rfc;

        public string NOMBRE
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string APPPATERNO
        {
            get { return appPaterno; }
            set { appPaterno = value; }
        }

        public string APPMATERNO
        {
            get { return appMaterno; }
            set { appMaterno = value; }
        }

        public string FECHANACIMIENTO
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public string RFC (string nombre, string appPaterno, string appMaterno, string fechaNacimiento)
        {
            rfc = appPaterno.Substring(0,1) + appMaterno.Substring(0) + nombre.Substring(0) + fechaNacimiento.Substring(9,10)+fechaNacimiento.Substring(4,5)+fechaNacimiento.Substring(0,1);
            return rfc;
        }
    }

    public class Contacto : Persona
    {
        protected string telefono;
        protected string correoElectronico;

        public string TELEFONO
        {
            get { return telefono; }
            set { correoElectronico = value; }
        }

        public string CORREOELECTRONICO
        {
            get { return correoElectronico; }
            set { correoElectronico = value; }
        }
    }
}
