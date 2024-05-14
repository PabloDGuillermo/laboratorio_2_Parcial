using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDC_Parcial
{
    public class Consulta
    {
        private DateTime fecha;
        private Paciente paciente;

        public DateTime Fecha
        {
            get { return this.fecha; }
        }

        public Paciente Paciente
        {
            get { return this.paciente; }
        }

        public Consulta(DateTime fecha, Paciente paciente)
        {
            this.fecha = fecha;
            this.paciente = paciente;
        }

        public override string ToString()
        {
            return $"{this.fecha} se ha atendido a {this.paciente.ToString()}";
        }
    }
}
