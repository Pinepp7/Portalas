using Portalas.Contract;
using Portalas.Models;
using Portalas.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portalas.Servies
{
    public class PostServies : IPostServies
    {
        private readonly IpostRepository _postRepository;
        private readonly IVartotojaiRepository _vartotojuRepository;

        public PostServies(IVartotojaiRepository vartotojuRepository, IpostRepository postRepository)
        {
            _postRepository = postRepository;
            _vartotojuRepository = vartotojuRepository;
        }

        public async Task AtnajantiPosta(Post post)
        {
            _postRepository.AtnajantiPosta(post);
        }

        public async Task AtnajantiVartotoja(Vartotojas vartotojas)
        {
            _vartotojuRepository.AtnajantiVartotoja(vartotojas);
        }

        public async Task<List<Post>> GautiVisusPostus()
        {
            return await _postRepository.GautiVisusPostus();
        }

        public async Task<List<Vartotojas>> GautiVisusVartotojus()
        {
            return await _vartotojuRepository.GautiVisusVartotojus();
        }

        public async Task IrasytiPosta(Post post)
        {
            _postRepository.IrasytiPosta(post);
        }

        public async Task IrasytiVartotoja(Vartotojas vartotojas)
        {
            _vartotojuRepository.IrasytiVartotoja(vartotojas);
        }

        public async Task IstrintiPosta(Post post)
        {
            _postRepository.IstrintiPosta(post);
        }

        public async Task IstrintiVartotoja(Vartotojas vartotojas)
        {
            _vartotojuRepository.IstrintiVartotoja(vartotojas);
        }

        public async Task PaieskaPagalId(int id)
        {
            _postRepository.PaieskaPagalId(id);
        }

        public async Task PaieskaVartotojoPagalId(int id)
        {
            _vartotojuRepository.PaieskapagalVartotojolId(id);
        }

 
    }
}



