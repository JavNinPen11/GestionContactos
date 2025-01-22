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
        string?[] nombres = new string[TamañoMaximo];
        string?[] telefonos = new string[TamañoMaximo];

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
        public (bool, int) VerificarTelefono(string telefono)
        {
            bool existe = false;
            int posicion = 0;
            for (int i = 0; i < telefono.Length && existe == false; i++)
            {
                if (telefonos[i] == telefono)
                {
                    existe = true;
                    posicion = i;
                }
            }
            return (existe, posicion);
        }
        public void ModificarContacto(string nombre, string telefono, int posicion)
        {
            nombres[posicion] = nombre;
            telefonos[posicion] = telefono;
        }
        public (string, string) MostrarContactos()
        {
            string cadenaNombres = string.Empty;
            string cadenaTelefonos = string.Empty;
            for (int i = 0; i < TamañoMaximo; i++)
            {
               if (nombres[i] != null)
                {
                    cadenaNombres += nombres[i] + ", ";
                    cadenaTelefonos += telefonos[i] + ", ";
                }
            }

            return (cadenaNombres, cadenaTelefonos);
        }
        private void btnAñadirContacto_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Ingrese el nombre del contacto");
            string telefono = Interaction.InputBox("Ingrese el telefono del contacto");

            if (telefonos[telefonos.Length - 1] != null)
            {
                if (AñadirContacto(nombre, telefono))
                {
                    MessageBox.Show("Se han introducido los datos satisfactoriamente");
                }
                else
                {
                    MessageBox.Show("No se han introducido los datos satisfactoriamente");
                }
            }
            else
            {
                MessageBox.Show("La lista de contactos ya ha sido llenada por completo\nElimine un contacto antes de " +
                    "añadir uno más");
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

        private void btnModificarContacto_Click(object sender, EventArgs e)
        {
            string telefono = Interaction.InputBox("Ingrese el telefono del contacto a editar");
            bool existe;
            int posicion;
            (existe, posicion) = VerificarTelefono(telefono);
            if (existe)
            {
                string nombre = Interaction.InputBox("Ingrese el nombre nuevo");
                telefono = Interaction.InputBox("Ingrese el telefono nuevo");
                ModificarContacto(nombre, telefono, posicion);
                MessageBox.Show("Se ha modificado satisfactoriamente");
            }
            else
            {
                MessageBox.Show("El numero introducido no existe");
            }
        }

        private void btnMostrarContactos_Click(object sender, EventArgs e)
        {
            string cadenaNombres;
            string cadenaTelefonos;
            (cadenaNombres, cadenaTelefonos) = MostrarContactos();
            MessageBox.Show($"Los nombres y telefonos de los contactos son : \n" +
                $"{cadenaNombres} \n{cadenaTelefonos}");
        }
    }
}
