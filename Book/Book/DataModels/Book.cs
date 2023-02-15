﻿using System.Xml.Linq;

namespace libary.DataModels
{
    public class Book : IEquatable<Book>
    {
        static int counter = 0;
        public Book()
        {
            this.Id = ++counter;
        }
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public int PageCount { get; set; }
        public int Price { get; set; }
        public int Authorİd { get; set; }

        public bool Equals(Book? other)
        {
            return other?.Id == this.Id; 
        }

        public override string ToString()
        {
            return $"{Id} | {Name}";
        }


    }
}