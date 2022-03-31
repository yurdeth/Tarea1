namespace TareaLibro
{
    //La clase EmpleadoAsalariado que extiende a empleado
    public class EmpleadoAsalariado:Empleado
    {
        private decimal _salarioSemanal;
        
        //Constructor con cuatro parámetros
        public EmpleadoAsalariado(string nombre, string apellido, string nss, decimal salario) : base(nombre, apellido, nss)
        {
            _salarioSemanal = salario;//Valida el salario a través de una propiedad
        }//Fin del constructor de EmpleadoAsalariado con cuatro parámetros

        //Propiedad que obtiene y establece el salario del empleado asalariado
        public decimal SalarioSemanal
        {
            get
            {
                return _salarioSemanal;
            }//Fin del get
            set
            {
                _salarioSemanal = ((value >= 0) ? value : 0);
            }//Fin del set
        }//Fin de la propiedad SalarioSemanal
        
        //Calcula los ingresos; redefine el método abstracto Ingresos en Empleado
        public override decimal Ingresos()
        {
            return SalarioSemanal;
        }//Fin de método Ingresos
        
        //Devuelve representación string del objeto EmpleadoAsalariado
        public override string ToString()
        {
            return string.Format("Empleado asalariado: {0}\n{1}: {2:C}", base.ToString(), "salario semanal", SalarioSemanal);
        }//Fin del método ToString
    }//Fin de la clase EmpleadoAsalariado
}