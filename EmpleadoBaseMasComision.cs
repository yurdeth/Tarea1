namespace TareaLibro
{
    //La clase EmpleadoBaseMasComision que extiende a EmpleadoPorComsision
    public class EmpleadoBaseMasComision:EmpleadoPorComision
    {
        private decimal _salarioBase; //Salario base por semana
        
        //Constructor con seis parámetros
        public EmpleadoBaseMasComision(string nombre, string apellido, string nss, decimal ventas, decimal tarifa, decimal salario) 
            : base(nombre, apellido, nss, ventas, tarifa)
        {
            _salarioBase = salario; //Valida el salario base a traves de una propiedad
        }//Fin del constructor de EmpleadoBaseMasComision con seis parámetros
        
        //Propiedad que obtiene y establece el salario base por comisión con salario base
        public decimal SalarioBase
        {
            get
            {
                return _salarioBase;
            }//Fin del get
            set
            {
                _salarioBase = (value >= 0) ? value : 0; //Validación
            }//Fin del set
        }//Fin de la propiedad SalarioBase
        
        //Calcular los ingresos; redefine el método Ingresos en EmpleadoPorComision
        public override decimal Ingresos()
        {
            return SalarioBase + base.Ingresos();
        }//Fin del método Ingresos
        
        //Devuelve representación string del objeto EmpleadoBaseMasComision
        public override string ToString()
        {
            return string.Format("{0} {1}; {2}: {3:C}", "Salario base", base.ToString(), "Salario base", SalarioBase);
        }//Fin del método ToString
    }//Fin de la clase EmpleadoBaseMasComision
}