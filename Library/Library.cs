using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Library
    {
        public List<LibraryItem> items = new List<LibraryItem>();
        public void AddItem(LibraryItem item)
        {
            items.Add(item);
            Console.WriteLine($"Item {item.Title} has been added to the Librarry");
        }
        public void DisplayLibrary()
        {
            Console.WriteLine("Library collection:");
            foreach (LibraryItem item in items)
            {
                item.DisplayInfo();
            }
        }
        public void BorrowItem(string title)
        {
            var item = default(LibraryItem);
            foreach (var i in items)
            {
                if (i.Title == title)
                {
                    item = i;
                    break;
                }
            }
            if (item is IBorrowable borrowableItem)
            {
                borrowableItem.Borrow();
            }
            else
            {
                Console.WriteLine($"Item {title} is not available for borrowing");
            }
        }
        public void ReturnItem(string title)
        {
            var item = default(LibraryItem);
            foreach (var i in items)
            {
                if (i.Title == title)
                {
                    item = i;
                    break;
                }
            }
            if (item is IBorrowable borrowableItem)
            {
                borrowableItem.Return();
            }
            else
            {
                Console.WriteLine($"Item {title} is not available for returning");
            }

        }

    }
}
