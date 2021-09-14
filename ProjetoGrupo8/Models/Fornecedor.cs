using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGrupo8.Models
{
    public class Fornecedor : Pessoa
    {
        public string baseCod = "RF000";
        public int idFornecedor = 0;
        public string fornecedorTxt = "fornecedor.txt";

        public string NomeFornecedor { get; set; }

        public string CnpjFornecedor { get; set; }

        public static List<Pessoa> ListaFornecedor { get; set; } = new List<Pessoa>();

        public Fornecedor(string tipoPessoa, string nomeFornecedor, string cnpjFornecedor, string telefone, string email) 
            : base(tipoPessoa, telefone, email)
        {
            idFornecedor += idFornecedor;
            TipoPessoa = tipoPessoa;
            NomeFornecedor = nomeFornecedor;
            CnpjFornecedor = cnpjFornecedor;
            Telefone = telefone;
            Email = email;
        }

        public override void CadastrarPessoa(Pessoa pessoa)
        {
            ListaFornecedor.Add(pessoa);
            Utils.EscreverTxt(ListaFornecedor, fornecedorTxt);
        }

        public override void Imprimir()
        {
            foreach (var pessoa in ListaFornecedor)
            {
                Console.WriteLine(pessoa);
            }
        }

        public override string ToString()
        {
            return $"Id: {baseCod}{idFornecedor}, nome: {NomeFornecedor}, CPF: {CnpjFornecedor} \n";
        }
    }
}
