using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGrupo8.Models
{
    public class Endereco
    {
        public Endereco(string logradouro, string numero, string cEP, string cidade, string bairro, string estado)
        {
            
        }
        public Endereco()
        {

        }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string CEP { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }
    }
}
