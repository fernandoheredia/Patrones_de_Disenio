public class Singleton
{
    private static Singleton instance = null;

    public string mensaje = "";
    protected Singleton() {
        mensaje = "Patron Singleton";
    }

    public static Singleton Instance
    {
        get
        {
          if (instance == null)
          instance = new Singleton();

          return instance;
        }
    }
}