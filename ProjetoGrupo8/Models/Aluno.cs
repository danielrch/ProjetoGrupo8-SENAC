using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGrupo8.Models
{
    public class Aluno : Pessoa
    {
        public string baseCod = "RA000";
        public string alunoTxt = "aluno.txt";
        int idAluno;

        public string NomeAluno { get; set; }

        public string CpfAluno { get; set; }

        public static List<Pessoa> ListaAluno { get; set; } = new List<Pessoa>();

        public Aluno(string tipoPessoa, string nomeAluno, string cpfAluno, string telefone, string email)
            : base(tipoPessoa, telefone, email)
        {
            idAluno++;
            TipoPessoa = tipoPessoa;
            NomeAluno = nomeAluno;
            CpfAluno = cpfAluno;
            Telefone = telefone;
            Email = email;
        }

        public override void CadastrarPessoa(Pessoa pessoa)
        {
            ListaAluno.Add(pessoa);
            Utils.EscreverTxt(ListaAluno, alunoTxt);
        }

        public override void Imprimir()
        {
            foreach (var pessoa in ListaAluno)
            {
                Console.WriteLine(pessoa);
            }
        }

        public override string ToString()
        {
            return $"Id: {baseCod}{idAluno}, nome: {NomeAluno}, CPF: {CpfAluno} \n";
        }
    }
}
