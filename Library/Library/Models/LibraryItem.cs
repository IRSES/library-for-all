using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    [Serializable]
    public abstract class LibraryItem
    {
        private int id;
        private string author;
        private string title;
        private string description;

        public int Id
        {
            get { return this.id; }
            private set { this.id = value; }
        }
        public string Author
        {
            get { return this.author; }
            private set { this.author = value; }
        }
        public string Title
        {
            get { return this.title; }
            private set { this.title = value; }
        }
        public string Description
        {
            get { return this.description; }
            private set { this.description = value; }
        }

        public void SetValues(int id, string author, string title, string description)
        {
            Id = id;
            Author = author;
            Title = title;
            Description = description;
        }

        public LibraryItem(int id, string author, string title, string description)
        {
            Console.WriteLine("Object has been created!");
            SetValues(id, author, title, description);
        }

        public override string ToString()
        {
            return $"ID: {Id}, Author: {Author}, Title: {Title}, Description: {Description}";
        }
    }
}
