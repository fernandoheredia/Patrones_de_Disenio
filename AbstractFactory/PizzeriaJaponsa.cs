namespace Patrones_de_Diseño.AbstractFactory
{
    public class PizzeriaJaponesa : Pizzeria
    {
        public override Pizza CrearPizza()
        {
            return new PizzaSushi();
        }

        public override Empanada CrearEmpanada()
        {
            return new EmpanadaCeviche();
        }
    }
}