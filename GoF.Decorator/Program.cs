using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // This sample demonstrates the Decorator pattern in which 'borrowable' functionality
            // is added to existing library items (books and videos). 
            
            // Create book
            Book book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();

            // Create video
            Video video = new Video("Spielberg", "Jaws", 23, 92);
            video.Display();

            // Make book borrowable, then borrow and display
            Console.WriteLine("\nMaking book borrowable:");
            BorrowableItem borrowbook = new BorrowableItem(book);
            borrowbook.BorrowItem("Customer #1");
            borrowbook.BorrowItem("Customer #2");
            borrowbook.Display();

            // Make video borrowable, then borrow and display
            Console.WriteLine("\nMaking video borrowable:");
            BorrowableItem borrowvideo = new BorrowableItem(video);
            borrowvideo.BorrowItem("Customer #3");
            borrowvideo.BorrowItem("Customer #4");
            borrowvideo.Display();

            // Wait for user
            Console.ReadKey();
        }
    }
}
