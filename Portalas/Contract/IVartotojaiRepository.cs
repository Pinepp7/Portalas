using Portalas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portalas.Contract
{
  public interface IVartotojaiRepository
    {
        Task IrasytiVartotoja(Vartotojas vartotojas);
        Task IstrintiVartotoja(Vartotojas vartotojas);
        Task <List<Vartotojas>> GautiVisusVartotojus();
        Task AtnajantiVartotoja(Vartotojas vartotojas);
        Task PaieskapagalVartotojolId(int id);

    }
}
