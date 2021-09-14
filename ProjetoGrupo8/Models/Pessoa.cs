using ProjetoGrupo8.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGrupo8
{
    public class Pessoa : Endereco
    {
        public int Id { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public string TipoPessoa { get; set; }

        public Pessoa(string telefone, string email, string tipoPessoa, int id = 1)
        {

        }

        public Pessoa(string telefone, string email, string tipoPessoa, string logradouro, string numero, string cep, string cidade, string bairro, string estado)
            :base(logradouro, numero, cep, cidade, bairro, estado)
        {

        }

        public virtual void CadastrarPessoa(Pessoa pessoa)
        {
        }
        
        public virtual void Imprimir()
        {
        }
    }
}
