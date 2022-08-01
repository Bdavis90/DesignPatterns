namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton instance;

        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            if (instance is null)
            {
                instance = new Singleton();
            }

            return instance;
        }
    }
}