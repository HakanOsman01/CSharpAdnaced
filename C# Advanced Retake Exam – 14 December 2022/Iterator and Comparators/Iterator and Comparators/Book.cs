using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_and_Comparators
{
    public class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public int  Year { get; set; }
        public List<string> Authors=new List<string>();
        public Book(string title,int year,params string[]authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors=authors.ToList();


        }

        public int CompareTo(Book other)
        {
           int result = this.Year.CompareTo(other.Year);
            if(result == 0)
            {
                return Title.CompareTo(other.Title);
            }
            return result;

        }
    }
}
