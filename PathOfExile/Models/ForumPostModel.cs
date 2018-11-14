using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PathOfExile.Models
{
    public class ForumPostModel
    {
        public int Forum_Id { get; set; }

        public string UserName { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }

        public DateTime PostDate { get; set; }
    }
}
