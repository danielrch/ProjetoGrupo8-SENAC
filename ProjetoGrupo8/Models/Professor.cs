using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGrupo8.Models
{
    public class Professor : Pessoa  
    {
        public string baseCod = "RP00";
        public int idProfessor = 0;
        public string professorTxt = "professor.txt";

        public string NomeProfessor { get; set; }

        public string CpfProfessor { get; set; }

        public static List<Pessoa> ListaProfessor { get; set; } = new List<Pessoa>();

        public Professor(string tipoPessoa, string nomeProfessor, string cpfProfessor, string telefone, string email) 
            : base(tipoPessoa, telefone, email)
        {
            idProfessor += idProfessor;
            TipoPessoa = tipoPessoa;
            NomeProfessor = nomeProfessor;
            CpfProfessor = cpfProfessor;
            Telefone = telefone;
            Email = email;
        }

        public override void CadastrarPessoa(Pessoa pessoa)
        {
            ListaProfessor.Add(pessoa);
            Utils.EscreverTxt(ListaProfessor, professorTxt);
        }
        public override void Imprimir()
        {
            foreach (var pessoa in ListaProfessor)
            {
                Console.WriteLine(pessoa);
            }
        }

        public override string ToString()
        {
            return $"Id: {baseCod}{idProfessor}, nome {NomeProfessor}, CPF {CpfProfessor} \n";
        }

    }
}
