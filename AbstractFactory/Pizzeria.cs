namespace Patrones_de_Diseño.AbstractFactory
{
    public abstract class Pizzeria
    {
        public abstract Pizza CrearPizza();
        public abstract Empanada CrearEmpanada();
    }
}