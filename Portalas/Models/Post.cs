using Microsoft.Identity.Client;
using Portalas.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portalas.Models;

namespace Portalas.Models
{
    public class Post
    {
        public int Id { get; set; }
        public Vartotojas user { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreateData { get; set; }

        public Post()
        {

        }
        public Post(int id, Vartotojas users, string title, string content, DateTime createData)
        {
            Id = id;
            user = users;
            Title = title;
            Content = content;
            CreateData = createData;
        }
    }
}
