using Portalas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portalas.Contract
{
    public interface IPostServies
    {
        Task IrasytiPosta(Post post);
        Task IstrintiPosta(Post post);
        Task<List<Post>> GautiVisusPostus();
        Task AtnajantiPosta(Post post);
        Task PaieskaPagalId(int id);
        Task IrasytiVartotoja(Vartotojas vartotojas);
        Task IstrintiVartotoja(Vartotojas vartotojas);
        Task<List<Vartotojas>> GautiVisusVartotojus();
        Task AtnajantiVartotoja(Vartotojas vartotojas);
        Task PaieskaVartotojoPagalId(int id);

    }
}
