namespace Patrones_de_Diseño.AbstractFactory
{
 public abstract class Pizza
    {
        protected string _descripcion;

        public object Descripcion
        {
            get
            {
                return _descripcion;
            }
        }
    }
}