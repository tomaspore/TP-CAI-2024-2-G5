using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TP_CAI_2024_G5.Forms
{
    public partial class FrmMenuAdmin : Form
    {
        public FrmMenuAdmin()
        {
            InitializeComponent();

        }

        private void btnRegistrarUser_Click(object sender, EventArgs e)
        {
            FrmRegistro registro = new FrmRegistro();


            registro.Show();
        }
    }
}
