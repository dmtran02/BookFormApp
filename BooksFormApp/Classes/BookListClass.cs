using BooksFormApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Handles all of the file operations for the books
 */

namespace BooksFormApp.Classes
{
    class BookListClass
    {
        private BookClass Book = new BookClass();
        private int index;

        private List<BookClass> InternalList;

        public BookListClass()
        {
            InternalList = new List<BookClass>(3);
        }

        public bool findKeywordInList(string keyword)
        {
            Boolean success = false;
            while(success == false && index < InternalList.Count)
            {
                if(InternalList[index].checkBookKeyword(keyword) == true)
                {
                    success = true;
                    return true;
                }
                else
                {
                    index++;
                }
            }
            index = 0;
            return false;
        }
    }
}
