Student student = new()
{
    Name = "Selim",
};

Book book = new Book()
{
    Name= "Asil Kan",
    Author= "Kazım Yurdakul",
};

//var s = student + book; // Bu şekilde işlem yapamayız o yüzden overloading yapmamız gerekiyor ki + opoeratörüyle 2 nesne arasında istediğimiz işlemi yapsın çünkü .n3t te böyle bir özellik yok.

var s = student + book;
class Student
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }


}
class Book
{
    public string Name { get; set; }
    public string Author { get; set; }
    public static Student operator +(Student s, Book b)
    {
        s.Books.Add(b);
        return s;
    }


}