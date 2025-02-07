
class Test

{
    //No Args constructor
    int i,a;
    string s;
    bool b;
    public Test()
    {
        Console.WriteLine("Constructor defined Explicitly");
        Console.WriteLine(i);
    }

    //Args constructor
    public Test(int a,int b)
    {
        Console.WriteLine("Constructor defined Explicitly");
        Console.WriteLine(a);
        Console.WriteLine(this.a);
    }
    public static void P(string [] args)
    {
        Test t = new Test();
        Test t1 = new Test(20,30);
    }


}

//Constructor is a special method present inside a class responsible for initializing the variable of that class
//When you compile your program the above program will look like

//class Test
//{
//    public Test()
//    {
//        i = 0;
//    }
//}



















