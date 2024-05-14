using System.Text;

namespace BDC_Parcial
{
    public abstract class Persona
    {
        protected string apellido;
        protected string nombre;
        protected string barrioResidencia;
        protected DateTime nacimiento;

        public string NombreCompleto
        {
            get
            { return $"{this.apellido}, {this.nombre}"; }
        }

        public int Edad
        {
            get
            { return DateTime.Today.AddTicks(-this.nacimiento.Ticks).Year - 1; }
        }

        public Persona(string nombre, string apellido, DateTime nacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
        }

        public Persona(string nombre, string apellido, DateTime nacimiento, string barrioResidencia):this(nombre, apellido, nacimiento)
        {
            this.barrioResidencia = barrioResidencia;
        }

        public override string ToString()
        {
            return this.NombreCompleto;
        }

        public static string FichaPersonal(Persona p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre completo: {p.ToString()}");
            sb.AppendLine($"EDAD: {p.Edad}");
            sb.AppendLine(p.FichaExtra());

            return sb.ToString();
        }

        internal abstract string FichaExtra();
    }
}
