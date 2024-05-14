using BDC_Parcial;

namespace FrmAtencion
{
    public partial class FrmAtencion : Form
    {
        public FrmAtencion()
        {
            InitializeComponent();
        }

        private void FrmAtencion_Load(object sender, EventArgs e)
        {
            lstMedicos.Items.Add(new PersonalMedico("Gustavo", "Rivas", new DateTime(1999, 12, 12), false));
            lstMedicos.Items.Add(new PersonalMedico("Lautaro", "Galarza", new DateTime(1951, 11, 12), true));
            lstPacientes.Items.Add(new Paciente("Mathias", "Bustamante", new DateTime(1998, 6, 16), "Tigre"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Ferrini", new DateTime(1989, 1, 21), "DF"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Rodriguez", new DateTime(1912, 12, 12), "LaBoca"));
            lstPacientes.Items.Add(new Paciente("John Jairo", "Trelles", new DateTime(1978, 8, 30), "Medellin"));
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            if (lstMedicos.SelectedItems.Count <= 0 || lstPacientes.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Debe seleccionar un Medico y un Paciente para poder continuar", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Paciente paciente = (Paciente)lstPacientes.SelectedItem;
                PersonalMedico medico = (PersonalMedico)lstMedicos.SelectedItem;
                paciente.Diagnostico = "Paciente curado";
                Consulta consulta = medico + paciente;
                lstPacientes.SelectedItems.Clear();
                lstMedicos.SelectedItems.Clear();

                MessageBox.Show(consulta.ToString(), "Atención finalizada", MessageBoxButtons.OK);
            }
        }

        private void lstMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbInfoMedico.Text = Persona.FichaPersonal((PersonalMedico)lstMedicos.SelectedItem);
        }
    }
}
