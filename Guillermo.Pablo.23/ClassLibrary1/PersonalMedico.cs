using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BDC_Parcial
{
    public class PersonalMedico:Persona
    {
        private List<Consulta> consultas;
        private bool esResidente;

        public PersonalMedico(string nombre, string apellido, DateTime nacimiento, bool esResidente):base(nombre, apellido, nacimiento)
        {
            this.esResidente = esResidente;
            consultas = new List<Consulta>();
        }

        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"¿Finalizó residencia?: ");
            if (this.esResidente)
            {
                sb.AppendLine("Si");
            }
            else
            {
                sb.AppendLine("No");
            }
            sb.AppendLine("ATENCIONES:");
            if(this.consultas.Count > 0)
            {
                foreach (Consulta consulta in this.consultas)
                {
                    sb.AppendLine(consulta.ToString());
                }
            }

            return sb.ToString();
        }

        public static Consulta operator +(PersonalMedico doctor, Paciente paciente)
        {
            Consulta consulta = new Consulta(DateTime.Now, paciente);
            doctor.consultas.Add(consulta);
            return consulta;
        }
    }
}
