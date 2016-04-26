﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Entities
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public byte[] PreviewImage { get; set; }
        public virtual ApplicationUser Author { get; set; }

        public Comment()
        {
            this.CreateDate = DateTime.Now;
        }
    }
}
