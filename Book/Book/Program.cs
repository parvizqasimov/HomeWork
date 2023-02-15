using libary.DataModels;
using libary.Managers;

namespace libary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AuthorManager authormanager = new AuthorManager();
            BookManager bookmanager = new BookManager();


            var Author = new Author();
            Author.Name = "Chingiz Abdullayev";
            authormanager.Add(Author);

            var Author1 = new Author();
            Author1.Name = "Semed Vurgun"; 
            authormanager.Add(Author1);

            var Author2 = new Author();
            Author2.Name = "Suleyman Rustam";
            authormanager.Add(Author2);

            var forRemove = new Author(1);
            authormanager.Remove(forRemove);


            foreach (var item in authormanager)
            {
                Console.WriteLine(item);
            }

            var reNew = new Author(3)
            {
                Name = "Abdulla Shaiq"
            };
            authormanager.Edit(reNew);

            Console.WriteLine("------------------");
            foreach (var item in authormanager)
            {
                Console.WriteLine(item);
            }

        }
    }
}