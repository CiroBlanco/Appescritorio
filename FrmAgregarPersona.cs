using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Calculadora_IMC
{
    public partial class FrmAgregarPersona : Form
    {
        public FrmAgregarPersona()
        {
            InitializeComponent();
        }
        public Persona(string nombre, string apellido, int dni, string genero, string tel, string correo, int direccion, DateTime fechaNac)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Genero = genero;
            Telefono = tel;
            Correo_Electronico = correo;
            Direccion = direccion;
            FechadeNacimiento = fechaNac;

        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            SqliteConnection conexion;
            string consulta = $"INSERT INTO registroimc(nombre,apellido,dni,genero,telefono,correo_electronico,direccion) VALUES('{nombre}','{apellido}','{dni}','{genero}','{telefono}','{correo_electronico}','{direccion}')";
            conexion.Open();
            SqliteCommand comando= new SqliteCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
           
        }
    }
    }

}
