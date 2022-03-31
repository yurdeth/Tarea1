namespace TareaLibro
{
    //La clase EmpleadoPorComision que extiende a Empleado
    public class EmpleadoPorComision:Empleado
    {
        private decimal _ventasBrutas; //Ventas semanales totales
        private decimal _tarifaComision; // Porcentaje de comisión
        
        //Constructor con cinco parámetros

        public EmpleadoPorComision(string nombre, string apellido, string nss, decimal ventas, decimal tarifa) : base(nombre, apellido, nss)
        {
            _ventasBrutas = ventas; //Valida las ventas brutas a traves de una propiedad
            _tarifaComision = tarifa; //Valida la tarifa de comisión a traves de una propiedad
        }//Fin del constructor de EmpleadoPorComision con cinco parámetros
        
        //Propiedad que obtiene y establece la tarifa de comisión del empleado por comisión
        public decimal TarifaComision
        {
            get
            {
                return _tarifaComision;
            }//Fin del get
            set
            {
                _tarifaComision = (value > 0 && value < 1) ? value : 0; //Validación
            }//Fin del set
        }//Fin de la propiedad TarifaComision
        
        //Propiedad que obtiene y establece las ventas brutas del empleado por comisión
        public decimal VentasBrutas
        {
            get
            {
                return _ventasBrutas;
            }//Fin del get
            set
            {
                _ventasBrutas = (value >= 0) ? value : 0;
            }//Fin del set
        }//Fin de la propiedad VentasBrutas
        
        //Calcula los ingresos; redefine el método abstracto Ingresos en Empleado
        public override decimal Ingresos()
        {
            return TarifaComision * VentasBrutas;
        }//Fin del método Ingresos
        
        //Devuelve representación string del objeto EmpleadoPorComision
        public override string ToString()
        {
            return string.Format("{0}: {1}\n{2}: {3:C}\n{4}: {5:F2}", "Empleado por comision", base.ToString(),
                "Ventas brutas", VentasBrutas, "Tarifa de comision", TarifaComision);
        }//Fin del método ToString
    }//Fin de la clase EmpleadoPorComsision
}