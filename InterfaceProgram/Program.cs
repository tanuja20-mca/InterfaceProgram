
using System;
interface Perform
{
    void add();
    void display();
}
class Test : Perform
{
    public void add()
    {
        int num1=10,num2=20,result;

       result= num1 + num2;

        Console.WriteLine("Sum is :" + result);

    }

    public void display()
    {
        Console.WriteLine("Addition Operation is performed successFully");
    }
    public static void Main(string[] args)
    {
        Test t= new Test();
        t.add();
        t.display();
        Console.ReadLine();
    }
}