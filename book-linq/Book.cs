using System;

namespace book_linq
{
    public class Book

    {
        public string Title { set; get; }
        public int PageCount { set; get; }
        public DateTime PublishedDate { set; get; }
        public string ThumbnailUrl { set; get; }
        public string ShortDescription { set; get; }
        public string Status { set; get; }
        public string[] Authors { set; get; }
        public string[] Categories { set; get; }



    }
}