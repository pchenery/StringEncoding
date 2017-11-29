using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsCE
{
    class Book
    {
        private string title;
        private string authors;

        const int maxTitleLen = 27;
        const int maxAuthorsLen = 31;

        public DateTime Published { get; set; }
        public string Title
        {
            get { return title; }
            set
            {
                if (value.Length > maxTitleLen)
                {
                    title = value.Substring(0, maxTitleLen - 3) + "...";
                }
                else
                {
                    title = value;
                }
            }
        }

        public string Authors
        {
            get { return authors; }
            set
            {
                if (value.Length > maxAuthorsLen)
                {
                    authors = value.Substring(0, maxAuthorsLen - 3) + "...";
                }
                else
                {
                    authors = value;
                }
            }
        }
    }
}
