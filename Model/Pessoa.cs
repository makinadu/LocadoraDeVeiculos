using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Model
{
    [Table("Pessoas")]
    class Pessoa : BaseModel
    {
        public Pessoa()
        {
            CriadoEm = DateTime.Now;
        }
       
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string CNH { get; set; }
        public string DataNascimento { get; set; }
        public string EMail { get; set; }
        public string Genero { get; set; }
        public string Endereço { get; set; }
        public string Bairro { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        

        public override string ToString() => $" Nome: {Nome} | CPF: {CPF} |CNH: {CNH} | DataNascimento: {DataNascimento} | EMail: {EMail} |  Genero: { Genero} | Endereço: { Endereço} | Bairro: { Bairro} | Telefone1: { Telefone1} | Telefone2: { Telefone2} | CriadoEm: { CriadoEm} ";



    }
}
