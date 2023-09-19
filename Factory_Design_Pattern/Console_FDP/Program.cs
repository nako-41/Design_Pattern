

A? a = (A)ProductCreator.GetInstance(ProductType.A);
a.Run();

B b=(B)ProductCreator.GetInstance(ProductType.B);
b.Run();


interface IProduct
#region Concrete Products
{
    void Run();
}

class A : IProduct
{
    public void Run()
    {
        throw new NotImplementedException();
    }
}



class B : IProduct
{
    public void Run()
    {
        throw new NotImplementedException();
    }
}



class C : IProduct
{
    public void Run()
    {
        throw new NotImplementedException();
    }
}

#endregion



#region
enum ProductType
{
    A, B, C
}

class ProductCreator
{
    public static IProduct GetInstance(ProductType productType)
    {
        IProduct _product = null;

        if (productType == ProductType.A)
        {
            _product = new A();
            // A nesnesi uretilecek
        }
        else if (productType == ProductType.B)
        {
            _product = new B();
            // B nesnesi uretilecek
        }
        else if (productType == ProductType.C)
        {
            _product = new C();
            // C nesnesi uretilecek
        }
        return _product;
    }
}


#endregion





