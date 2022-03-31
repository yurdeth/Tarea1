namespace TareaLibro
{
    //La clase EmpleadosPorHora que se extiende a Empleado
    public class EmpleadoPorHoras:Empleado
    {
        private decimal _sueldo; //Sueldo por hora
        private decimal _horas; //Horas trabajadas durante la semana
        
        //Constructor con cinco parámetros
        public EmpleadoPorHoras(string nombre, string apellido, string nss, decimal sueldoPorHoras, decimal horasTrabajadas) 
            : base(nombre, apellido, nss)
        {
            _sueldo = sueldoPorHoras; //Valida el sueldo por horas a traves de una propiedad
            _horas = horasTrabajadas; //Valida las horas trabajadas a traves de una propiedad
        }//Fin del constructor de cinco parámetros
        
        //Propiedad que obtiene y establece el sueldo del empleado por horas
        public decimal Sueldo
        {
            get
            {
                return _sueldo;
            }//Fin del get
            set
            {
                _sueldo = (value >= 0) ? value : 0; //Validación
            }//Fin del set
        }//Fin de la propiedad Sueldo

        public decimal Horas
        {
            get
            {
                return _horas;
            }//Fin del get
            set
            {
                _horas = ((value >= 0) && (value <= 168)) ?  value : 0; //Validación
            }//Fin del set
        }//Fin de la propiedad Horas
        
        //Calcula los ingresos; redefine el método abstracto Ingresos de Empleado
        public override decimal Ingresos()
        {
            if (Horas <= 40) //No hay tiempo extra
            {
                return Sueldo * Horas;
            }
            
                return (40 * Sueldo) + ((Horas - 40) * Sueldo * 1.5M);
        }//Fin de método ingresos

        public override string ToString()
        {
            return string.Format("Empleado por horas: {0}\n{1}: {2:C}; {3}: {4:F2}", base.ToString(), "Sueldo por horas", Sueldo, "Horas trabajadas", Horas);
        }//Fin del método ToString
    }//Fin de la clase EmpleadoPorHoras
}