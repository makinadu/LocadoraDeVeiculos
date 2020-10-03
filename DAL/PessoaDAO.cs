using LocadoraDeVeiculos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.DAL
{
    class PessoaDAO
    {
        private static Context _context = new Context();
        public static Pessoa BuscarPorCpf(string CPF) => _context.Pessoas.FirstOrDefault(x => x.CPF == CPF);
        public static bool Cadastrar(Pessoa pessoa)
        {
            if (BuscarPorCpf(pessoa.CPF) == null)
            {
                _context.Pessoas.Add(pessoa);
                _context.SaveChanges();
                return true;
            }
            return false;
        }


    }
}
