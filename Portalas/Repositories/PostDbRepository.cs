using Microsoft.EntityFrameworkCore;
using Portalas.Contract;
using Portalas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portalas.Repositories
{
    public class PostDbRepository : IpostRepository
    {
        public async Task AtnajantiPosta(Post post)
        {
            using (var context = new MyDbContext())
            {

                context.puslapis.Update(post);
                context.SaveChanges();
            }

        }

        public async Task<List<Post>> GautiVisusPostus()
        {
            using (var context = new MyDbContext())
            {
                List<Post> visipostai = context.puslapis.ToList();
                return visipostai;
            }
        }

        public async Task IrasytiPosta(Post post)
        {
            using (var context = new MyDbContext())
            {

                context.puslapis.Add(post);
                context.SaveChanges();

            }
        }

        public async Task IstrintiPosta(Post post)
        {
            using (var context = new MyDbContext())
            {

                context.puslapis.Remove(post);
                context.SaveChanges();

            }
        }

        public async Task PaieskaPagalId(int id)
        {
            using (var context = new MyDbContext())
            {

                context.puslapis.Find(id);
                context.SaveChanges();

            }
        }
    }
}
