using BooksFormApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksFormApp.Classes
{
    class UpdatedBookFileClass
    {
        private string updatedFilePath;
        private System.IO.StreamWriter updatedFileSW;
        private int recordWrittenCount;

        public UpdatedBookFileClass(string filepath)
        {
            recordWrittenCount = 0;
            updatedFilePath = filepath;
            try
            {
                updatedFileSW = new System.IO.StreamWriter(updatedFilePath);
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot open file" + updatedFilePath + "Terminate Program.", "Input File Connection Error.");
            }
        }

        public void putNextRecord(string record)
        {
            try
            {
                updatedFileSW.WriteLine(record);
                Console.WriteLine(record);
            }
            catch (Exception)
            {
                MessageBox.Show("IO error in file write. Terminate program.", "File Write Error");
            }
            recordWrittenCount++;
        }

        public void closeFile()
        {
            updatedFileSW.Flush();
            updatedFileSW.Close();
        }

        public void rewindFile()
        {
            recordWrittenCount = 0;
            closeFile();
            updatedFileSW = new System.IO.StreamWriter(updatedFilePath);
            updatedFileSW.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
        }
    }
}
