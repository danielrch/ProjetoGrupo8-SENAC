using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGrupo8.Models
{
    public class Fornecedor : Pessoa
    {
        private readonly string baseCod = "RF00";
        public string fornecedorTxt = "fornecedor.txt";

        private static int IdFornecedor { get; set; }

        private string NomeFornecedor { get; set; }

        private string CnpjFornecedor { get; set; }

        private static List<Pessoa> ListaFornecedor { get; set; } = new List<Pessoa>();

        public Fornecedor(string tipoPessoa, string nomeFornecedor, string cnpjFornecedor, string telefone, string email) 
            : base(tipoPessoa, telefone, email)
        {
            TipoPessoa = tipoPessoa;
            NomeFornecedor = nomeFornecedor;
            CnpjFornecedor = cnpjFornecedor;
            Telefone = telefone;
            Email = email;
            IdFornecedor++;
        }

        public Fornecedor
            (string tipoPessoa, string nomeFornecedor, string cnpjFornecedor, string telefone, string email, string logradouro, string numero, string cep, string cidade, string bairro, string estado)
            : base(tipoPessoa, telefone, email, logradouro, numero, cep, cidade, bairro, estado)
        {
            TipoPessoa = tipoPessoa;
            NomeFornecedor = nomeFornecedor;
            CnpjFornecedor = cnpjFornecedor;
            Telefone = telefone;
            Email = email;
            Logradouro = logradouro;
            Numero = numero;
            CEP = cep;
            Cidade = cidade;
            Bairro = bairro;
            Estado = estado;
            IdFornecedor++;
        }

        public override void CadastrarPessoa(Pessoa pessoa)
        {
            ListaFornecedor.Add(pessoa);
            Utils.EscreverTxt(ListaFornecedor, fornecedorTxt);
        }

        
        public override string ToString()
        {
            return $"Id: {baseCod}{IdFornecedor++}, Nome: {NomeFornecedor}, CNPJ: {CnpjFornecedor} \n";
        }

        // OVERRIDE COM DADOS COMPLETOS. PARA USAR, COMENTAR O OVERRIDE ACIMA E DESCOMENTAR ESTE
        //public override string ToString()
        //{
        //    return $"Id: {baseCod}{idFornecedor}, Pessoa: {TipoPessoa}, Nome: {NomeFornecedor}, CNPJ: {CnpjFornecedor}, Telefone: {Telefone}, Email: {Email}" +
        //        $", Logradouro: {Logradouro}, Numero: {Numero}, CEP: {CEP}, Cidade: {Cidade}, Bairro: {Bairro}, Estado: {Estado} \n";
        //}
    }
}
