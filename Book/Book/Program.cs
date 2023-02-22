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
            int id;

            L1:
            switch (SelectedMenu)
            {
                case MenuTypes.AuthorAdd:
                    author = new Author();
                    author.Name = PrimitiveHelper.ReadString("Muellifin adi :");
                    authormanager.Add(author);
                    author = new Author();
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
                        goto case MenuTypes.AuthorEdit;
                    }
                    author.Name = PrimitiveHelper.ReadString("Muellifin adi:");
                    Console.Clear();
                    goto case MenuTypes.AuthorGetAll;
                    //break;
                case MenuTypes.AuthorRemove:
                    Console.WriteLine("Silmek etmek istediyiniz muellif adini secin:");
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
                    string name= PrimitiveHelper.ReadString("axtar;sh ucun adin en azi 3 herfini qeyd edin!")
                    var data = authormanager.FindByName(name);
                    if (data.Length == 0)
                    {
                        Console.WriteLine("tapilmadi");                        
                    }
                    goto L1;
                    foreach (var item in data)
                    {
                        Console.WriteLine(item);
                    }



                case MenuTypes.BookAdd:
                    break;
                case MenuTypes.BookEdit:
                    break;
                case MenuTypes.BookFindByName:
                    break;
                case MenuTypes.BookGetAll:
                    break;
                case MenuTypes.BookGetById:
                    break;
                case MenuTypes.BookRemove:
                    break;

            }



        }
    }
}