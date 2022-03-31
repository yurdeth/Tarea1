namespace TareaLibro
{
    public abstract class Empleado
    {
        private string _primerNombre;
        private string _apellidoPaterno;
        private string _numeroSeguroSocial;
        
        //Constructor con 3 parámetros
        public Empleado(string nombre, string apellido, string nss)
        {
            _primerNombre = nombre;
            _apellidoPaterno = apellido;
            _numeroSeguroSocial = nss;
        }//Fin del constructor del empleado con 3 parámetros
        
        //Propiedad de solo lectura que obtiene el primer nombre 
        public string PrimerNombre
        {
            get
            {
                return _primerNombre;
            }//Fin de get
        }//Fin de la propiedad PrimerNombre
        
        //Propiedad de sólo lectura que obtiene el apellido paterno del empleado
        public string ApellidoPaterno
        {
            get
            {
                return _apellidoPaterno;
            }//Fin del get
        }//Fin de la propiedad apellido paterno
        
        //Propiedad de sólo lectura que obtiene el número de seguro social del empleado 
        public string NumeroSeguroSocial
        {
            get
            {
                return _numeroSeguroSocial;
            }//Fin de get
        }//Fin de la propiedad NumeroSeguroSocial
        
        //Devuelve representación string del objeto Empleado, usando las propiedades
        public override string ToString()
        {
            return string.Format("{0} {1}\nNumero de seguro social: {2}", PrimerNombre, ApellidoPaterno, NumeroSeguroSocial);
        }//Fin del método ToString

        //Método abstracto redefinido por las clases derivadas
        public abstract decimal Ingresos();
    }//Fin de la clase abstracta Empleado
}