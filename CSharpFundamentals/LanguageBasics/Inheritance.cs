// Types: Single, MultiLevel, Multiple, Hybrid
// Polymorphism: Method overriding

class A
{
    public int x;
    public void Test()
    {
        Console.WriteLine("I am from class A");
    }

    public virtual void Do()
    {
        Console.WriteLine("I am doing something from class A");
    }
}

class B: A  // Class B is derived from class A or class B is of type A
{
    public int y;
    public new void Test()
    {
        base.Test();
        Console.WriteLine("I am from class B");
    }

    public override void Do()
    {
        base.Do();
        Console.WriteLine("I am doing something from class B");
    }
}

class C: B
{
    public double z;
}

interface IC
{
    public void Test1();
}

// Multiple
class D: B, IC  // D inherits from class B and implements inteface IC
{
    public void Test1()
    {
        Console.WriteLine("Implementing interface method...");
    }
}


class E : IC
{
    public void Test1()
    {        
    }
}