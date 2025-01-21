using Microsoft.VisualBasic;
using System.Reflection.Metadata;

namespace GestionContactos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int TamañoMaximo = 10;
        string[] nombres = new string[TamañoMaximo];
        string[] telefonos = new string[TamañoMaximo];

        public bool VerificarContacto(string telefono)
        {
            bool unico = true;
            for (int i = 0; i < telefonos.Length && unico == true; i++)
            {
                if (telefono == telefonos[i])
                {
                    unico = false;
                }
            }
            return unico;
        }
        public bool AñadirContacto(string nombre, string telefono)
        {
            bool valido = true;
            bool espacio = false;
            if (!VerificarContacto(telefono))
            {
                valido = false;
            }
            else
            {
                for (int i = 0; i < nombres.Length && espacio == false; i++)
                {
                    if (nombres[i] == null)
                    {
                        espacio = true;
                        nombres[i] = nombre;
                        telefonos[i] = telefono;
                    }
                }
            }
            return valido;


        }

        public bool BorrarContacto(string telefono)
        {
            bool existe = false;
            int posicion = -1;
            for (int i = 0; i < telefonos.Length && existe == false; i++)
            {
                if (telefonos[i] == telefono)
                {
                    existe = true;
                    posicion = i;
                }
            }
            if (existe)
            {
                nombres[posicion] = null;
                telefonos[posicion] = null;
            }

            return existe;
        }

        private void btnAñadirContacto_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Ingrese el nombre del contacto");
            string telefono = Interaction.InputBox("Ingrese el telefono del contacto");

            if (AñadirContacto(nombre, telefono))
            {
                MessageBox.Show("Se han introducido los datos satisfactoriamente");
            }
            else
            {
                MessageBox.Show("No se han introducido los datos satisfactoriamente");
            }
        }

        private void btnBorrarContacto_Click(object sender, EventArgs e)
        {
            string telefono = Interaction.InputBox("Ingrese el telefono del contacto");

            if (BorrarContacto(telefono))
            {
                MessageBox.Show("Se han eliminado los datos satisfactoriamente");
            }
            else
            {
                MessageBox.Show("No se han eliminado los datos");
            }
        }
    }
}
