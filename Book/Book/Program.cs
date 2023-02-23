using libary.DataModels;
using libary.Enums;
using libary.Helper;
using libary.Managers;

namespace libary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AuthorManager authormanager = new AuthorManager();
            BookManager bookmanager = new BookManager();

            Console.WriteLine("Emeliyyati siyahidan secin");

            var SelectedMenu = EnamHelper.ReadEnum<MenuTypes>("Menyu: ");
            

            Author author;
            Book book;
            int id;

        L1:
            switch (SelectedMenu)
            {
                case MenuTypes.AuthorAdd:
                    author = new Author();
                    author.Name = PrimitiveHelper.ReadString("Muellifin adi :");
                    author.Surename = PrimitiveHelper.ReadString("Muellifin Soyadi :");
                    authormanager.Add(author);
                    Console.Clear();
                    Console.WriteLine("Emeliyyati siyahidan secin");
                    SelectedMenu = EnamHelper.ReadEnum<MenuTypes>("Menyu: ");
                    goto L1;
                case MenuTypes.AuthorEdit:
                    Console.WriteLine("Redakte etmek istediyiniz muellifin id-sini secin:");
                    foreach (var item in authormanager)
                    {
                        Console.WriteLine(item);
                    }
                    id = PrimitiveHelper.ReadInt("Muellifin idsi ");

                    if (id == 0)
                    {
                        Console.WriteLine("Emeliyyati siyahidan secin");
                        SelectedMenu = EnamHelper.ReadEnum<MenuTypes>("Menyu: ");

                        goto L1;
                    }

                    author = authormanager.GetBiyID(id);

                    if (author == null)
                    {
                        Console.Clear();
                        goto case MenuTypes.AuthorEdit;
                    }
                    author.Name = PrimitiveHelper.ReadString("Muellifin adi:");
                    author.Surename = PrimitiveHelper.ReadString("Muellifin Soyadi :");
                    Console.Clear();
                    goto case MenuTypes.AuthorGetAll;
                //break;
                case MenuTypes.AuthorRemove:
                    Console.WriteLine("Silmek istediyiniz muellif adini secin:");
                    foreach (var item in authormanager)
                    {
                        Console.WriteLine(item);
                    }
                    id = PrimitiveHelper.ReadInt("Muellif id ");
                    author = authormanager.GetBiyID(id);
                    if (author == null)
                    {
                        Console.Clear();
                        goto case MenuTypes.AuthorRemove;
                    }
                    authormanager.Remove(author);
                    Console.Clear();
                    goto case MenuTypes.AuthorGetAll;
                //break;
                case MenuTypes.AuthorGetAll:
                    Console.Clear();
                    foreach (var item in authormanager)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("Emeliyyati siyahidan secin");
                    SelectedMenu = EnamHelper.ReadEnum<MenuTypes>("Menyu: ");
                    goto L1;
                case MenuTypes.AuthorGetById:

                    id = PrimitiveHelper.ReadInt("Muellif id ");
                    if (id == 0)
                    {
                        Console.WriteLine("Emeliyyati siyahidan secin");
                        SelectedMenu = EnamHelper.ReadEnum<MenuTypes>("Menyu: ");

                        goto L1;
                    }
                    author = authormanager.GetBiyID(id);
                    if (author == null)
                    {
                        Console.Clear();
                        Console.WriteLine("Tapilmadi..");
                        goto case MenuTypes.AuthorGetById;
                    }
                    Console.WriteLine(author);

                    Console.WriteLine("Emeliyyati siyahidan secin");
                    SelectedMenu = EnamHelper.ReadEnum<MenuTypes>("Menyu: ");

                    goto L1;
                case MenuTypes.AuthorFindByName:
                //string name= PrimitiveHelper.ReadString("axtarish ucun adin en azi 3 herfini qeyd edin!")
                //var data = authormanager.FindByName(name);
                //if (data.Length == 0)
                //{
                //    Console.WriteLine("tapilmadi");                        
                //}
                //goto L1;
                //foreach (var item in data)
                //{
                //    Console.WriteLine(item);
                //}
                //goto L1;

                case MenuTypes.BookAdd:
                    book = new Book();
                    book.Name = PrimitiveHelper.ReadString("Kitabin adi:");
                    book.PageCount = PrimitiveHelper.ReadInt("Kitabin sehife sayi:");
                    book.Price = PrimitiveHelper.ReadInt("Kitabin qiymeti:");

                    Console.WriteLine("Kitabin janrini secin!");
                    
                    book.genre = EnamHelper.ReadEnum <Genre>("Kitabin janri:");

                    bookmanager.Add(book);
                    Console.Clear();
                    Console.WriteLine("Emeliyyati siyahidan secin");
                    SelectedMenu = EnamHelper.ReadEnum<MenuTypes>("Menyu: ");
                    goto L1;

                case MenuTypes.BookEdit:
                    Console.WriteLine("Redakte etmek istediyiniz kitabin id-sini secin:");
                    foreach (var item in bookmanager)
                    {
                        Console.WriteLine(item);
                    }
                    id = PrimitiveHelper.ReadInt("Kitabin idsi ");

                    if (id == 0)
                    {
                        Console.WriteLine("Emeliyyati siyahidan secin");
                        SelectedMenu = EnamHelper.ReadEnum<MenuTypes>("Menyu: ");

                        goto L1;
                    }

                    book = bookmanager.GetBiyID(id);

                    if (book == null)
                    {
                        Console.Clear();
                        goto case MenuTypes.BookEdit;
                    }
                    book.Name = PrimitiveHelper.ReadString("Kitabin adi:");
                    book.PageCount = PrimitiveHelper.ReadInt("Kitabin sehife sayi:");
                    book.Price = PrimitiveHelper.ReadInt("Kitabin qiymeti:");
                    book.genre = EnamHelper.ReadEnum<Genre>("Kitabin janri:");

                  

                    Console.Clear();
                    goto case MenuTypes.BookGetAll;

                case MenuTypes.BookFindByName:
                    break;
                case MenuTypes.BookGetAll:
                    Console.Clear();
                    foreach (var item in bookmanager)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("Emeliyyati siyahidan secin");
                    SelectedMenu = EnamHelper.ReadEnum<MenuTypes>("Menyu: ");
                    goto L1;

                case MenuTypes.BookGetById:

                    id = PrimitiveHelper.ReadInt("Kitabin id ");
                    if (id == 0)
                    {
                        Console.WriteLine("Emeliyyati siyahidan secin");
                        SelectedMenu = EnamHelper.ReadEnum<MenuTypes>("Menyu: ");

                        goto L1;
                    }
                    book = bookmanager.GetBiyID(id);
                    if (book == null)
                    {
                        Console.Clear();
                        Console.WriteLine("Tapilmadi..");
                        goto case MenuTypes.BookGetById;
                    }
                    Console.WriteLine(book);

                    Console.WriteLine("Emeliyyati siyahidan secin");
                    SelectedMenu = EnamHelper.ReadEnum<MenuTypes>("Menyu: ");

                    goto L1;

                case MenuTypes.BookRemove:
                    Console.WriteLine("Silmek istediyiniz kitabin adini secin:");
                    foreach (var item in bookmanager)
                    {
                        Console.WriteLine(item);
                    }
                    id = PrimitiveHelper.ReadInt("Kitabin id ");
                    book = bookmanager.GetBiyID(id);
                    if (book == null)
                    {
                        Console.Clear();
                        goto case MenuTypes.BookRemove;
                    }
                    bookmanager.Remove(book);
                    Console.Clear();
                    goto case MenuTypes.BookGetAll;


            }

            

           

            }
    }
}