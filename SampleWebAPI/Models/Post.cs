using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebAPI.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Content { get; set; }
    }
}