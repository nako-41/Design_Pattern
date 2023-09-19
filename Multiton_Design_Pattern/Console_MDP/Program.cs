var mssql = Database.GetInstance("mssql");
var oracle = Database.GetInstance("oracle");


var mssql2 = Database.GetInstance("mssql");
var oracle2 = Database.GetInstance("oracle");

Console.ReadLine();

class Database
{
    private Database()
    {
        Console.WriteLine($"{nameof(Database)} nesnesi uretildi");
    }


    static Dictionary<string, Database> _databases = new Dictionary<string, Database>();

    public static Database GetInstance(string key)
    {
        if (!_databases.ContainsKey(key))
        {
            _databases[key] = new Database();
        }

        return _databases[key];
    }

}