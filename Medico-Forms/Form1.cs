using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medico_Forms
{
    public partial class Form1 : Form
    {
        MedicosService.SegipServiceSoapClient segipService = new MedicosService.SegipServiceSoapClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {
            String CI = textBoxCI.Text;
            bool isValid = segipService.VerificarCI(CI);
            if (isValid)
            {
                MessageBox.Show("Cédula válida.");
                Form formReceta = new RecetaForm();
                formReceta.Show();
            }
            else
            {
                MessageBox.Show("Cédula inválida.");
            }
        }
    }
}
