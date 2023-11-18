using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp_07Oct2023.OOPS.Encapsulation;

namespace ConsoleApp_07Oct2023.GenericsExample
{
    class Book
    {
        public static int IdentitySeed;
        public int BookId { get; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }

        public Book()
        {
            BookId = IdentitySeed++;
        }
        static Book()
        {
            IdentitySeed = 1;
        }

        public override string ToString()
        {
            return string.Format($"Book Id : {BookId} Name : {Name}  Price : {Price} Qty : {Qty}");
        }
    }
    class BookRepository
    {
        private readonly List<Book> books;

        public BookRepository()
        {
            books = new List<Book>();
        }
        public void AddBook()
        {

            Console.Write("Enter Name : ");
            string Name = Console.ReadLine();

            Console.Write("Enter Price : ");
            int Price = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Qty : ");
            int Qty = Convert.ToInt32(Console.ReadLine());


            Book Existingbook = books.FirstOrDefault(x => x.Name == Name && x.Price == Price);
           
            if (Existingbook == null)
            {
                Book book = new Book()
                {
                    Name = Name,
                    Price = Price,
                    Qty = Qty
                };
                books.Add(book);
            }
            else
            {
                Existingbook.Qty = Existingbook.Qty + Qty;
            }


        }

        public void Display()
        {
            Console.WriteLine("-----------------Book Details---------------");
            if(books.Count() > 0)
            {
                foreach (Book item in books)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine("\t No Data! \t");
            }

            Console.WriteLine("---------------------End-----------------");

        }

        static void Main(string[] args)
        {
            BookRepository repository = new BookRepository();
            char IsContinue;
            Console.WriteLine("============================");
            Console.WriteLine("1-Add \t 2-Disp");
            Console.WriteLine("============================");
            do
            {
                Console.Write("Select => ");
                int Operator = Convert.ToInt32(Console.ReadLine());

                switch (Operator)
                {
                    case 1:
                        repository.AddBook();
                        break;
                    case 2:
                        repository.Display();
                        break;
                    default:
                        Console.WriteLine("Opps! Invalid input entered.");
                        break;
                }

                Console.Write("To Continue, Press Y : ");
                IsContinue = Console.ReadKey().KeyChar;
                IsContinue = char.ToLower(IsContinue);
                Console.WriteLine();
            } while (IsContinue == 'y');
        }
    }
}
