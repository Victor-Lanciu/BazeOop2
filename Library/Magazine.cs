using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Magazine : LibraryItem, IBorrowable
    {
        public bool IsBorrowed { get; set; }
        public Magazine(string title, string author, int publicationYear) : base(title, author, publicationYear)
        {
            IsBorrowed = false;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Magazine: {Title}, Author: {Author}, Year: {PublicationYear}, Borrowed: {IsBorrowed}");
        }
        public void Borrow()
        {
            if (IsBorrowed)
            {
                Console.WriteLine($"The Magazine {Title} is already borroewd");
            }
            else
            {
                IsBorrowed = true;
                Console.WriteLine($"You have borrowed the Magazine {Title}");
            }
        }
        public void Return()
        {
            if (!IsBorrowed)
            {
                Console.WriteLine($"The magazine {Title} wasn't borrowed");
            }
            else
            {
                IsBorrowed = false;
                Console.WriteLine($"The magazine {Title} is returned");
            }
        }

    }
}
