using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Entities
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public virtual ICollection<Comment> Comments{ get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    
        public Post()
        {
            this.CreateDate = DateTime.Now;
        }
    }
}
