using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // INHERITED CLASS
    public class EBook : Book
    {
        public string format;

        // Constructor (Inherited)
        public EBook(string aTitle, string aAuthor, int aPages, string aFormat)
            : base(aTitle, aAuthor, aPages)
        {
            format = aFormat;
        }


        public bool IsDigital()
        {
            if (format == "PDF")
            {
                return true;
            }
            return false;
        }

        // Overrided Method
        public override void Reading()
        {
            Console.WriteLine("You are reading digital ebook");
        }
    }
}
