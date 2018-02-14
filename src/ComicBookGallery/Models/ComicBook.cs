using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        //Models can contain both attributes and behaviors

        public int ID { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public string[] Artists { get; set; }
        public bool Favorite { get; set; }

        //Read-Only because we only defined a getter property and not a setter
        public string DisplayTest
        {
            get
            {
                return SeriesTitle + " #" + IssueNumber;
            }
        }
        // series-tittle-issuenumber.jpg
        public string CoverImageFileName
        {
            get
            {
                return SeriesTitle.Replace(" ", "-")
                    .ToLower() + "-" + IssueNumber + ".jpg";
            }
        }

    }
}