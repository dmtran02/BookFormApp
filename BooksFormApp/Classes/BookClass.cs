using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Stores information about each individual book from file
 */

namespace BooksFormApp.Classes
{
    class BookClass
    {
        private string[] bookArray;

        private string bookTitle;
        private string bookAuthor;
        private string[] bookKeywords;

        private string hiddenBookTitle;
        private string hiddenBookAuthor;
        private string[] hiddenKeywords;

        public BookClass (string bkBookTitle, string bkBookAuthor, string[] bkBookKeywords)
        {
            bookTitle = bkBookTitle;
            bookAuthor = bkBookAuthor;
            bookKeywords = bkBookKeywords;
        }

        public Boolean createBookObject(string s)
        {


            string[] holder = s.Split('*');
            string[] bookString = new string[holder.Length];
            for(int j = 0; j < holder.Length; j++)
            {
                string trimmer = holder[j].Trim();
                bookString[j] = trimmer;
            }
            int i;

            int bookStringSize = bookString.GetLength(0);

            try
            {
                hiddenBookTitle = bookString[0];
                bookTitle = hiddenBookTitle;
                Console.WriteLine("Book Title: " + thisBook.bookTitle);
            }
        }
    }
}
