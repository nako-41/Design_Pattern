namespace WebAPI
{
    public class Database
    {
        private Database()
        {
            Console.WriteLine($"{nameof(Database)} is create");
        }
        private static Database _database;

        public static Database GetDatabase
        { 
            get
            {
                if (_database==null)
                {
                    _database = new Database();
                }
                return _database;
            }
        }

        public int Count { get; set; }

        public bool Connection()
        {
            Count++;
            Console.WriteLine("baglantı saglandı");
            return true;
        }

        public bool Disconnec()
        {
            Console.WriteLine("baglantı koptu");
            return true;
        }


    }
}
