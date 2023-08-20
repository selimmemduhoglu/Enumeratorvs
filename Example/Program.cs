#region Null Conditional Operatörü -> ?.

//Person person = null;

//if (DateTime.Now.Day == 30 )
//{
//    person = new();
//}

//                          //burada hata vermesinin sebebi NUll Condition da bu şekilde kullanamazsın çünkü assign etmek isteyecek.
//Console.WriteLine(person?.Name);   // bu şekide hata vermez

//class Person
//{
//    public string Name { get; set; }
//}


#endregion

#region Null Conditional Operatörü (Example-2) -> ?.


//Person person = new();

//Console.WriteLine(person?.Branch?.Department?.DepartmentName);
//class Person
//{
//    public string Name { get; set; }
//    public Branch Branch { get; set; }
//}
//class Branch
//{
//    public string  BranchName { get; set; }
//    public Department Department { get; set; }
//}
//class Department
//{
//    public string DepartmentName{ get; set; }

//}

#endregion

#region Null Coalescing Assigment Operatörü -> ??=


using System.Net.Cache;
using System.Threading;
///*person?.Name = "asd";*/ // burada ? nin anlamı person null değilse Name memberında assignment işlemini yapacak eğer ki person null ise hiçbir işlem yapmayacak.
///*person?.Name */ // bu şekilde hata verir.




#endregion

#region Null(?) Operatörü & Nullable<T> 
#endregion

#region is Operatörü
Person person = new Person()
{
Name = "Hilmi",
Age = 5,
Married = true,

};
if (person.Married)
{
person.Name = "selim";
Console.WriteLine(person.Name);
}
if (person is { Married: true, Age: > 4 })
{
person.Name = "muhammed";

Console.WriteLine(person.Name);

}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public bool Married { get; set; }
}

#endregion