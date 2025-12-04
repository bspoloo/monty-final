using Medico_Forms.Entities;
using Medico_Forms.Services;
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
    public partial class RecetaForm : Form
    {
        private RecetasService recetasService;
        public RecetaForm()
        {
            recetasService = new RecetasService("http://localhost:8000/api/recetas");
            InitializeComponent();
        }

        private async void  buttonInsert_Click(object sender, EventArgs e)
        {
            //int id = textBoxCod.Text;
            String NombrePaciente = textBoxNmPaciente.Text;
            String ApellidoPaciente = textBoxAPPaciente.Text;
            String Diagnostico = textBoxDiagnostico.Text;
            String Medicamentos = textBoxMedicamentos.Text;
            DateTime Fecha = DateTime.Parse(textBoxFecha.Text);
            String Estado = textBoxEstado.Text;
            //String Estado = "Activa";

            Receta receta = new Receta()
            {
                NombrePaciente = NombrePaciente,
                ApellidoPaciente = ApellidoPaciente,
                Diagnostico = Diagnostico,
                Medicamentos = Medicamentos,
                Fecha = Fecha,
                Estado = Estado
            };

            Receta createdReceta = await recetasService.createreceta(receta);
            if (createdReceta != null)
            {
                MessageBox.Show(
                   "Receta creada correctamente",
                   "Success",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation
               );
            }
            else
            {
                MessageBox.Show(
                    "Ocurrió un error en crear la receta",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void RecetaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
