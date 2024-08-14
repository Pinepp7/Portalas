using Portalas.Contract;
using Portalas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portalas.Repositories
{
    public class VartotojuDbRepository : IVartotojaiRepository
    {
        public async Task AtnajantiVartotoja(Vartotojas vartotojas)
        {
            using (var context = new MyDbContext())
            {

                context.vartotojas.Update(vartotojas);
                context.SaveChanges();
            }
        }

        public async Task<List<Vartotojas>> GautiVisusVartotojus()
        {
            using (var context = new MyDbContext())
            {
                List<Vartotojas> vartotojai = context.vartotojas.ToList();
                return vartotojai;
            }
        }

        public async Task IrasytiVartotoja(Vartotojas vartotojas)
        {
            using (var context = new MyDbContext())
            {

                context.vartotojas.Add(vartotojas);
                context.SaveChanges();
            }
        }

        public async Task IstrintiVartotoja(Vartotojas vartotojas)
        {
            using (var context = new MyDbContext())
            {

                context.vartotojas.Remove(vartotojas);
                context.SaveChanges();
            }
        }

        public async Task PaieskapagalVartotojolId(int id)
        {
            using (var context = new MyDbContext())
            {

                context.vartotojas.Find(id);
                context.SaveChanges();
            }
        }
    }
}

