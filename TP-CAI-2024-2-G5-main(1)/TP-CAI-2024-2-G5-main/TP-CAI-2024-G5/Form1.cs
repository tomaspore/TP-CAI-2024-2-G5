using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_CAI_2024_G5
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            //hola como estas
            
        }

        private int intentos; //Temporalmente la variable intentos va a estar acá

        private void button1_Click(object sender, EventArgs e)
        {
            Validacion validacionUntil = new Validacion();
            string usuario = "";
            string contraseña = "";

            usuario = txtUsuario.Text;
            contraseña = txtContraseña.Text;

           if (validacionUntil.ValidarVacio(usuario, contraseña))
           {
                 MessageBox.Show("Debe ingresar un usuario y/o contraseña.");
                 intentos++;
           }
           else
           {
               intentos = 0;
           }


           if (intentos == 3)
           {
                MessageBox.Show("El usuario " + usuario + " pasa a estado INACTIVO. El programa se cerrara.");
                intentos = 0;
                this.Close();
           }
           else if (intentos == 0)
           {
                MessageBox.Show("Bienvenido! " + usuario ); //Acá en un futuro voy a poner el nombre de la persona y no el user

                FrmRegistro registro = new FrmRegistro();

                registro.Show();
                

           }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
