
Example exe = Example.GetInstance;


Console.ReadKey();


class Example
{

    private Example()
    {
        Console.WriteLine($"{nameof(Example)} nesnesi olusturuldu");
    }

    //2. YONTEM 
    //Burada da static ile biliyoruz ki uygulamada bir kere nesne olusturacaktır.bir dahaki isteklerde olusturmayacaktır.

    static Example()
    {
        _example = new Example();
    }

    private static Example _example;

    public static Example GetInstance
    {
        get
        {

            #region 1. YONTEM
            if (_example == null)
            {
                _example = new Example();
            }
            #endregion

            return _example;

        }
    }

}
