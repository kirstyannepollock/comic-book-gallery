using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        public int ID { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favourite { get; set; }

        public string DisplayText
        {
            get
            {
                return String.Format("{0} #{1}", SeriesTitle, IssueNumber);
            }
        }

        public string CoverImageFileName
        { 
            get
            {
                return String.Format("{0}-{1}.jpg", SeriesTitle.Replace(" ","-").ToLower(), IssueNumber);
            }
        }
    }
}