using BooksFormApp.Classes;
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

        public BookClass()
        {
            // null
        }

        public Boolean createBookObject(string s)
        {
            BookClass thisBook = this;

            string[] holder = s.Split('*');
            string[] bookString = new string[holder.Length];
            for(int j = 0; j < holder.Length; j++)
            {
                string trimmer = holder[j].Trim();
                bookString[j] = trimmer;
            }

            int bookStringSize = bookString.GetLength(0);

            try
            {
                hiddenBookTitle = bookString[0];
                bookTitle = hiddenBookTitle;
                //Console.WriteLine("Book Title: " + thisBook.bookTitle);
            }
            catch
            {
                MessageBox.Show(bookString[0] + " AccessID string is not a valid integer. Employee File Corrupt. Execution Terminated.", "AccessID in Employee File Invalid");

                return false;
            }

            hiddenBookAuthor = bookString[1];
            if(hiddenBookAuthor == " " || hiddenBookAuthor == "")
            {
                MessageBox.Show(hiddenBookAuthor + ": Name string is empty or Blank. Employee File Corrupt. Execution Terminated.", "Name in Employee File Invalid");

                return false;
            }
            else
            {
                bookAuthor = hiddenBookAuthor;
            }



            bookArray = bookString;
            return true;
        }

        public void keywordSplitter(string keywords, out string[] keywordArray)
        {
            string[] holder = keywords.Split(',');
            string[] bookString = new string[holder.Length];
            for (int j = 0; j < holder.Length; j++)
            {
                string trimmer = holder[j].Trim();
                bookString[j] = trimmer;
            }
            keywordArray = bookString;
            bookKeywords = keywordArray;
        }

        public bool checkBookKeyword(string keyword)
        {
            if (bookKeywords.Contains(keyword)){
                return true;
            }
            return false;
        }
    }
}
