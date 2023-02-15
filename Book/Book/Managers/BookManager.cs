using libary.DataModels;
using libary.İnfastuctue;
using System.Collections;

namespace libary.Managers
{
    internal class BookManager : IManager<Book>, IEnumerable<Book>
    {
        Book[] data = new Book[0];

        public void Add(Book item)
        {
            int len = data.Length;
            Array.Resize(ref data, len + 1);
            data[len] = item;
        }
        public void Edit(Book item)
        {
            var index = Array.IndexOf(data, item);
            if (index == -1)
                return;
            var found = data[index];
            found.Name = item.Name;
            found.Authorİd = item.Authorİd;
        }

        public void Remove(Book item)
        {
            int index = Array.IndexOf(data, item);
            if (index == -1)
                return;
            int len = data.Length - 1;

            for (int i = index; i < len; i++)
            {
                data[i] = data[i + 1];
            }

            Array.Resize(ref data, len);
        }


       

        public Book this[int index]
        {
            get
            {
                return data[index];
            }

        }

        public IEnumerator<Book> GetEnumerator()
        {
            foreach (Book item in data)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

       
    }
}

