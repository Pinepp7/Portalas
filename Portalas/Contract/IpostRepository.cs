using Portalas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Portalas.Contract
{
   public interface IpostRepository
    {
        Task IrasytiPosta(Post post);
        Task IstrintiPosta(Post post);
        Task <List<Post>> GautiVisusPostus();
        Task AtnajantiPosta(Post post);
        Task PaieskaPagalId(int id);

    }
}
