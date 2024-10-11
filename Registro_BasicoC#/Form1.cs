using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions; // para usar el metodo regex, ismatch o importar caracteres
using MySql.Data.MySqlClient;

namespace Formulario_Registro
{
    public partial class Form1 : Form
    {
        string SqlConection = "Server=localhost; Port=3306; Database=programacionavanzada;Uid=root;Pwd=12345;";
        public Form1()
        {
            InitializeComponent();

            tbNombre.TextChanged += validarNombre;
            tbApellidos.TextChanged += validarApellido;
            tbEstatura.TextChanged += validarEstatura;
            tbEdad.TextChanged += validarEdad;
            //texTelefono.TextChanged += validarTelefono;
            tbTelefono.Leave += validarTelefono;

        }
        private void InsertarRegistro(string nombres, string apellidos, int edades, decimal estaturas, string telefonos, string genero)
        {
            using (MySqlConnection conection = new MySqlConnection(SqlConection))
            {
                conection.Open();

                string insertQuery = "INSERT INTO registro (nombre, apellidos, telefono, estatura, edad, genero)" +
                                    "VALUES (@nombre, @apellidos, @telefono, @estatura, @edad, @genero)";
                
                using (MySqlCommand command = new MySqlCommand(insertQuery, conection))
                {
                    command.Parameters.AddWithValue("@nombre", nombres);
                    command.Parameters.AddWithValue("@apellidos", apellidos);
                    command.Parameters.AddWithValue("@telefono", telefonos);
                    command.Parameters.AddWithValue("@estatura", estaturas);
                    command.Parameters.AddWithValue("@edad", edades);
                    command.Parameters.AddWithValue("@genero", genero);

                    command.ExecuteNonQuery();
                }
                conection.Close();
            }

        }
 
        private void btGuardar_Click(object sender, EventArgs e)
        {
            string nombres = tbNombre.Text;
            string apellidos = tbApellidos.Text;
            string edades = tbEdad.Text;
            string estaturas = tbEstatura.Text;
            string telefonos = tbTelefono.Text;
            string genero = "";
            if (rbHombre.Checked)
            {
                genero = "Hombre";
            }
            else if (rbMujer.Checked)
            {
                genero = "Mujer";
            }
            string datos = $"Nombres: {nombres}\r\nApellidos:{apellidos}\r\nEdad: {edades}\r\nEstatura: {estaturas}\r\nTelefono: {telefonos}\r\nGenero: {genero}";

            MessageBox.Show("Datos guardados con exito:\n\n" + datos, "Infomacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string rutaArchivo = "C:\\Users\\moral\\Downloads\\Programacion Avanzada3-M\\302024Datos";
            bool archivoExiste = File.Exists(rutaArchivo);

            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                if (archivoExiste)
                {
                    writer.WriteLine();
                }
                writer.WriteLine(datos);
                InsertarRegistro(nombres, apellidos, Int32.Parse(edades), decimal.Parse(estaturas), telefonos, genero);
            }
            // Mostrar un mensaje con los datos capturados
            MessageBox.Show("Datos guardados con éxito: \n\n" + datos, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool EsEnteroValido(string valor)
        {
            int resultado;
            return int.TryParse(valor, out resultado); //intenta convertir el valor boleano si el valor que se ingreso string es entero
        }
        private bool EsDecimalValido(string valor)
        {
            decimal resultado;
            return decimal.TryParse(valor, out resultado);
        }
        private bool EsEnteroValidoDeDigitos(string valor)
        {
            long resultado;
            return long.TryParse(valor, out resultado) && valor.Length == 10; // concatenamos una validacion doble, que el valor sea de 10 digitos
        }
        private bool EsTextoValido(string valor)
        {
            return Regex.IsMatch(valor, @"^[a-zA-Z\s]+$"); // Solo letras y espacios.
                                                           // ^ Comience la coincidencia al principio 
                                                           // $ Finalice la coincidencia al final de la cadena 
                                                           // @  Para declarar lo que vamos a validar (lo que esta "")
                                                           // \s caracter de espacio en blanco, por si hay dos nombres
        }

        // Metodos que van a invocar metodos que declaramos
        // Metodos que van a invocar metodos que declaramos
        private void validarEdad(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender; // recuperamos el textBox que estamos mandando a llamar 
            if (!EsEnteroValido(textBox.Text))
            {
                MessageBox.Show(" Ingrese una edad valida", "Error Edad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }
        private void validarTelefono(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length == 10 && EsEnteroValidoDeDigitos(textBox.Text))
            {
                textBox.BackColor = Color.Green;
            }
            else
            {
                textBox.BackColor = Color.Red;
                MessageBox.Show("Ingrese un telefono valido", "Error Telefono", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void validarNombre(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsTextoValido(textBox.Text))
            {
                MessageBox.Show("Ingrese un nombre valido", "Error Nombre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }
        private void validarApellido(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsTextoValido(textBox.Text))
            {
                MessageBox.Show("Ingrese un apellido valido", "Error Apellido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }
        private void validarEstatura(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsDecimalValido(textBox.Text))
            {
                MessageBox.Show("Ingrese una cifra valida", "Error Estatura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            tbNombre.Clear();
            tbEstatura.Clear();
            tbApellidos.Clear();
            tbEdad.Clear();
            tbTelefono.Clear();
            tbEdad.Clear();
            rbMujer.Checked = false;
            rbHombre.Checked = false;
        }
    }
}