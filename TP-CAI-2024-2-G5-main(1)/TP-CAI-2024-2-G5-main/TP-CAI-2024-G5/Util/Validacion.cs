using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_CAI_2024_G5
{
    public class Validacion
    {
        /*
        public bool ValidarCantidadCaracteres(string dato)
        {
            if (dato.Length < 8 || dato.Length > 15)
            {
                MessageBox.Show("El nombre ingresado tiene que tener entre 8 y 15 caracteres");

                return true;
            }

            return false;
        }

        */


        public bool ValidarVacio(string texto1, string texto2)
        {
            int intentos;

            if (string.IsNullOrEmpty(texto1) && string.IsNullOrEmpty(texto2))
            {
                
                return true;

            }
            else if (string.IsNullOrEmpty(texto1) || string.IsNullOrEmpty(texto2))
            {
                
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
