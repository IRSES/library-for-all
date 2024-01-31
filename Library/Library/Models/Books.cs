using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    [Serializable]
    public class Books : LibraryItem
    {
        private bool isRead;
        public bool IsRead
        {
            get { return isRead; }
            set { isRead = value; }
        }
        public int YearPublishing { get; set; }
        
        public Books(int id, string author, string title, int yearPublishing, string description) : base(id, author, title, description)
        {
            this.YearPublishing = yearPublishing;
        }

        public void MarkBookAsRead()
        {
            if (!IsRead)
            {
                IsRead = true;
                Console.WriteLine($"Book '{Title}' marked as read.");
            }
            else
            {
                Console.WriteLine($"Book '{Title}' is already marked as read.");
            }
        }
    }
}
