namespace NextTechnologies.Modelos
{
    public class NumeroFaltanteModel
    {

        // Lista de numeros 
        private List<int> numeros;

        // Constructor para inicializar la lista de numeros del 1 al 100 
        public NumeroFaltanteModel()
        {
            numeros = Enumerable.Range(1,100).ToList(); 
        }

        #region "Metodo para extraer num"
        public void ExtraerNum(int num)
        {
            if(num <1 || num > 100)
            {
                throw new ArgumentOutOfRangeException("El numero debe estar entre 1 y 100");
            }

            numeros.Remove(num);
        }
        #endregion

        #region "Determina el numero faltante"
        public int NumFaltante()
        {
            int SumaTotal = Enumerable.Range(1,100).Sum();  
            int SumaActual = numeros.Sum();
            return SumaTotal;
        }

        #endregion

        public List<int> NumerosRestantes()
        {
            // Devuelve la lista de numeros restantes con el num removido
            return numeros;
        }
       

    } // fin clase 
} // fin namespace 
