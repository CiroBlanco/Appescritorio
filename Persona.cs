using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Calculadora_IMC
{
    public abstract class Persona 
    {
        protected string nombre;
        protected string apellido;
        protected int dni;
        protected string genero;
        protected string telefono;
        protected string correoelectronico;
        protected int direccion;
        protected DateTime fechaDeNacimiento;
        protected float peso;
        protected float altura;
        protected float imc;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public int Dni { get { return dni; } set { dni = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; } }
        public string CorreoElectronico { get { return correoelectronico; } set { correoelectronico = value; } }
        public DateTime FechaDeNacimiento { get { return fechaDeNacimiento; } set { fechaDeNacimiento = value; } }
        public float Peso { get { return peso; } set { peso = value; } }
        public float Altura { get { return altura; } set { altura = value; } }
        public float IMC { get { return imc; } set { imc = value; } }
    }
}
