using DelegateMiniAppCode;
using DelegateMiniAppCode.Models;
// string name = Console.ReadLine();
// Console.WriteLine("Enter Email");
// string email = Console.ReadLine();
// Console.WriteLine("Enter Role");
// string role = Console.ReadLine();
// if (true)
// {

// }

// User user = new(name, email, role);

// Book book = new("Book1", "Author1", 100);

// while (true)
// {
//     Console.WriteLine("Menu ");
//     Console.WriteLine("1. Add book");
//     Console.WriteLine("2. Get book by id");
//     Console.WriteLine("3. Get all books");
//     Console.WriteLine("4. Delete book by id");
//     Console.WriteLine("5. Edit book name");
//     Console.WriteLine("6. Filter by page count");
//     Console.WriteLine("0. Quit");
// Option: string optionStr = Console.ReadLine();
//     bool isCorrectFormatOption = int.TryParse(optionStr, out int option);

//     if (isCorrectFormatOption)
//     {
//         switch (option)
//         {
//             case 1:
//                 libraryManager.AddBook(book);
//                 break;
//             case 2:
//                 libraryManager.GetBookById(3);
//                 break;




//         }
//     }

// }
using DelegateMiniAppCode;
using DelegateMiniAppCode.Models;
using Utils.Enums;

// Simple demo program — create the LibraryManager, add a book and print a message.
var libraryManager = new LibraryManager();
libraryManager.AddBook(new Book("B1", "A1", 100));

Console.WriteLine("Book added.\nPress any key to exit...");
Console.ReadKey();