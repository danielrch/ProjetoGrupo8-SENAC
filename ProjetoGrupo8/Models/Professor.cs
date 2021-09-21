using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGrupo8.Models
{
    public class Professor : Pessoa  
    {
        private readonly string baseCod = "RP00";
        public string professorTxt = "professor.txt";

        private static int IdProfessor { get; set; }

        private string NomeProfessor { get; set; }

        private string CpfProfessor { get; set; }

        private static List<Pessoa> ListaProfessor { get; set; } = new List<Pessoa>();

        public Professor(string tipoPessoa, string nomeProfessor, string cpfProfessor, string telefone, string email) 
            : base(tipoPessoa, telefone, email)
        {            
            TipoPessoa = tipoPessoa;
            NomeProfessor = nomeProfessor;
            CpfProfessor = cpfProfessor;
            Telefone = telefone;
            Email = email;
            IdProfessor++;
        }

        public Professor
            (string tipoPessoa, string nomeProfessor, string cpfProfessor, string telefone, string email, string logradouro, string numero, string cep, string cidade, string bairro, string estado)
            : base(tipoPessoa, telefone, email, logradouro, numero, cep, cidade, bairro, estado)
        {
            IdProfessor += IdProfessor;
            TipoPessoa = tipoPessoa;
            NomeProfessor = nomeProfessor;
            CpfProfessor = cpfProfessor;
            Telefone = telefone;
            Email = email;
            Logradouro = logradouro;
            Numero = numero;
            CEP = cep;
            Cidade = cidade;
            Bairro = bairro;
            Estado = estado;
            IdProfessor++;
        }

        public override void CadastrarPessoa(Pessoa pessoa)
        {
            ListaProfessor.Add(pessoa);
            Utils.EscreverTxt(ListaProfessor, professorTxt);
        }
        
        public override string ToString()
        {
            return $"Id: {baseCod}{IdProfessor++}, Nome {NomeProfessor}, CPF {CpfProfessor} \n";
        }

        // OVERRIDE COM DADOS COMPLETOS. PARA USAR, COMENTAR O OVERRIDE ACIMA E DESCOMENTAR ESTE
        //public override string ToString()
        //{
        //    return $"Id: {baseCod}{idProfessor}, Pessoa: {TipoPessoa}, Nome: {NomeProfessor}, CPF {CpfProfessor}, Telefone: {Telefone}, Email: {Email}" +
        //        $", Logradouro: {Logradouro}, Numero: {Numero}, CEP: {CEP}, Cidade: {Cidade}, Bairro: {Bairro}, Estado: {Estado} \n";
        //}

    }
}
