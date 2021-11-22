using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGrupo8.Models
{
    public class Aluno : Pessoa
    {
        private int id;

        private readonly string baseCod = "RA001";
        public string alunoTxt = "aluno.txt";

        private static int IdAluno { get; set; }

        private string NomeAluno { get; set; }

        private string CpfAluno { get; set; }

        private static List<Pessoa> ListaAluno { get; set; } = new List<Pessoa>();

        public Aluno(string tipoPessoa, string nomeAluno, string cpfAluno, string telefone, string email)
            : base(tipoPessoa, telefone, email)
        {
            TipoPessoa = tipoPessoa;
            NomeAluno = nomeAluno;
            CpfAluno = cpfAluno;
            Telefone = telefone;
            Email = email;
            id = IdAluno++;
        }

        public Aluno
            (string tipoPessoa, string nomeAluno, string cpfAluno, string telefone, string email, string logradouro, string numero, string cep, string cidade, string bairro, string estado)
            : base(tipoPessoa, telefone, email, logradouro, numero, cep, cidade, bairro, estado)
        {
            TipoPessoa = tipoPessoa;
            NomeAluno = nomeAluno;
            CpfAluno = cpfAluno;
            Telefone = telefone;
            Email = email;
            Logradouro = logradouro;
            Numero = numero;
            CEP = cep;
            Cidade = cidade;
            Bairro = bairro;
            Estado = estado;
            id = IdAluno++;
        }

        public override void CadastrarPessoa(Pessoa pessoa)
        {
            ListaAluno.Add(pessoa);
            Utils.EscreverTxt(ListaAluno, alunoTxt);
        }

        public override string ToString()
        {
            return $"Id: {baseCod}{id}, Nome: {NomeAluno}, CPF: {CpfAluno} \n";
        }

        // OVERRIDE COM DADOS COMPLETOS. PARA USAR, COMENTAR O OVERRIDE ACIMA E DESCOMENTAR ESTE
        //public override string ToString()
        //{
        //    return $"Id: {baseCod}{id}, Pessoa: {TipoPessoa}, Nome: {NomeAluno}, CPF {CpfAluno}, Telefone: {Telefone}, Email: {Email}" +
        //        $", Logradouro: {Logradouro}, Numero: {Numero}, CEP: {CEP}, Cidade: {Cidade}, Bairro: {Bairro}, Estado: {Estado} \n";
        //}
    }
}
