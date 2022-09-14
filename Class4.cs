using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects

{
    class Bookstore
    {


        public int isbn;
        public string bookname;
        public string booktitle;
        public string bookauthor;
        public int quantityofbooks;
        public int bookprice;


        public void Show()
        {
            Console.WriteLine($"isbn:{isbn}" + $"Book Name:{bookname}" + $"Book Title:{booktitle}" + $"Book Author:{bookauthor}" +
            $"Quantity: {quantityofbooks}" + $"Price:{bookprice}");
        }

        public static void Main()
        {
            //creating object
            Bookstore B1 = new Bookstore();
            B1.isbn = 3432;
            B1.bookname = "Think Like a Monk";
            B1.booktitle = "Change Your Lives";
            B1.bookauthor = "Jay Shetty";
            B1.quantityofbooks = 10;
            B1.bookprice = 500;

            B1.Show();

            ////Bookstore Array
            Bookstore[] Books = new Bookstore[2];
            Books[0] = new Bookstore()
            {
                isbn = 342983,
                bookname = "The 5 AM club",
                booktitle = "Own Your Morning , Evelavte Your Live",
                bookauthor = "Robin Sharma",
                quantityofbooks = 10,
                bookprice = 450


            };
            Books[1] = new Bookstore()
            {
                isbn = 342983,
                bookname = "Rich Dad, Poor Dad",
                booktitle = "What rich teaches their kid that poor doesn't",
                bookauthor = "Robert Kiyosaki",
                quantityofbooks = 100,
                bookprice = 600


            };

            foreach (var i in Books)
            {
                i.Show();
            }

        }
    }







}



