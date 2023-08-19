using System.ComponentModel;
using System.Reflection;


//int number = 2;
//MyEnum _d = (MyEnum)number;

//Console.WriteLine(MyEnum.error);
//Console.WriteLine((int)MyEnum.error);



//var ads = Enum.GetValues(typeof(MyEnum));

//foreach (var asas in ads)
//{
//    Console.WriteLine(asas);
//}

enum MyEnum
{
    [Description("Tamamlandı")]
    completed,
    [Description("HatalıAldı")]
    failed,
    [Description("HatalıFırlattı")]
    error
}


class Program
{
    static void Main(string[] args)
    {
        MyEnum myEnum = MyEnum.completed; // Örnek bir enum değeri seçin

        var description = ((DescriptionAttribute)Attribute.GetCustomAttribute(
            myEnum.GetType().GetField(myEnum.ToString()),
            typeof(DescriptionAttribute)
        ))?.Description;

        Console.Write(description);
    }
}




