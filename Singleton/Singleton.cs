public class Singleton
{
    private static Singleton instance = null;

    public string mensaje = "";
    private Singleton() {
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
public class Singleton2: Singleton
{
    private static List<Singleton> instances = null;
    public static List<Singleton> Instances
    {
        get
        {
            instances= new List<Singleton>();
            instances.Add(new Singleton2());
            instances.Add(new Singleton2());
            return instances;
        }
    }
}