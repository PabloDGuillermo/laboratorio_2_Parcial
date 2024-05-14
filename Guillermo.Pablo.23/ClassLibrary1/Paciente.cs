using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDC_Parcial
{
    public class Paciente:Persona
    {
        public string diagnostico;

        public string Diagnostico
        {
            get { return diagnostico; }
            set { diagnostico = value; }
        }

        public Paciente(string nombre, string apellido, DateTime nacimiento, string barrioResidencia):base(nombre, apellido, nacimiento, barrioResidencia)
        {

        }

        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Persona.FichaPersonal(this));
            sb.AppendLine($"Diagnóstico: {this.diagnostico}");

            return sb.ToString();
        }
    }
}
