
var t1 = Task.Run(() =>
{
    Example.GetInstanceFunc();
});


var t2 = Task.Run(() =>
{
    Example.GetInstanceFunc();
});

Task.WaitAll(t1, t2);

var t3 = Task.Run(() =>
{
    Example.GetInstanceFunc();
});

var t4 = Task.Run(() =>
{
    Example.GetInstanceFunc();
});

Task.WaitAll(t3, t4);

Console.ReadKey();


class Example
{

    private Example()
    {
        Console.WriteLine($"{nameof(Example)} nesnesi olusturuldu");
    }

    //2. YONTEM de en gecerli yontem cunku static constructar'da sadece bir kere olusacak,yani locka bile gerek kalmıyor

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




    // asenkron islemde lock olusturmadan once birden fazla nesne olusturma ihtimali oluyordu.
    //cunku if icine girebiliyorlar paralel sekilde
    //bunu engellemek icin lock islemini gerceklestirmek gerekli bu sekilde birden fazla instance islemi sona eriyo.

    private static object _obj = new object();

    public static Example GetInstanceFunc()
    {
        lock (_obj)
        {
            if (_example == null)
            {
                _example = new Example();
            }
        }


        return _example;
    }
}
