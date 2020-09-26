using System;
using System.Collections.Generic;
using System.Text;

namespace Introduction {
    class Book {
        public string title;
        public string author;
        public int pages;

        public Book(string aTitle, string aAuthor, int aPages) {
            this.title = aTitle;
            this.author = aAuthor;
            this.pages = aPages;
        }
    }
}
