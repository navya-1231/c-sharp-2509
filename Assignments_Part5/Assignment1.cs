using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_Part_5
{
    public class Library
    {

        public string[] Books= new string[5];
        public string Title {  get; set; }

        //to add books
        public Library(string[] books)
        {
            for (int i = 0; i < books.Length; i++)
            {
                Books[i] = books[i];
            }
        } 
        
        // Method to display all book titles in the library
        public void DisplayBooks()
        {
            Console.WriteLine("Books in the Library:");
            foreach (var book in Books)
            {
                Console.Write(book+",");
            }
        }
    }
    public class Classroom
    {
        public string[,] Seats=new string[2,3];
        public string SeatName;

        public Classroom(string[,] seats) 
        {
            try
            {
                for (int i = 0; i < seats.GetLength(0); i++)
                {
                    for (int j = 0; j < seats.GetLength(1); j++)
                    {
                        Seats[i, j] = seats[i, j];
                    }
                }
            }
            catch (Exception e)
            {
                   Console.WriteLine (e.Message);
            }
        }

        public void DisplaySeatingArrangement()
        {
            Console.WriteLine("Seat Arrangment");
            for (int i = 0; i < Seats.GetLength(0); i++)//rows
            {
                for (int j = 0; j < Seats.GetLength(1); j++)//columns
                {
                   Console.Write(Seats[i, j] + "\t");   
                }
                Console.WriteLine();
            }
        }


    }
}
