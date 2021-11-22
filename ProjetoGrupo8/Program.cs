using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoGrupo8;
using ProjetoGrupo8.Models;

namespace ProjetoGrupo8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CRIANDO ALUNO COM OS DADOS PEDIDOS NO CONSTRUTOR SIMPLES, SEM ENDEREÇO
            Aluno aluno1 = new Aluno("Física", "Daniel", "15158911549", "1198912222", "daniel@gmail.com");
            Aluno aluno2 = new Aluno("Física", "Rodrigo", "16158911543", "1177912222", "rodrigo@gmail.com");

            //CRIANDO PROFESSOR COM OS DADOS PEDIDOS NO CONSTRUTOR SIMPLES, SEM ENDEREÇO
            Professor professor1 = new Professor("Física", "David", "25298911549", "1178952222", "david@gmail.com");
            Professor professor2 = new Professor("Física", "Pollycarppus", "37868911543", "1158462222", "polly@gmail.com");

            //CRIANDO FORNECEDOR COM OS DADOS PEDIDOS NO CONSTRUTOR SIMPLES, SEM ENDEREÇO
            Fornecedor fornecedor1 = new Fornecedor("Jurídica", "Anilton", "40518911000142", "1177982222", "anilton@gmail.com");
            Fornecedor fornecedor2 = new Fornecedor("Jurídica", "Tiago", "30268911000135", "1198772222", "tiago@gmail.com");
                       
            // CADASTRANDO A PESSOA EM UMA LISTA E GERANDO O TXT - MÉTODO ESTÁ DENTRO DO CADASTRARPESSOA()
            aluno1.CadastrarPessoa(aluno1);
            aluno2.CadastrarPessoa(aluno2);            
            professor1.CadastrarPessoa(professor1);
            professor2.CadastrarPessoa(professor2);
            fornecedor1.CadastrarPessoa(fornecedor1);
            fornecedor2.CadastrarPessoa(fornecedor2);

            // RESGATANDO O CONTEÚDO DO TXT E EXIBINDO NO CONSOLE
            Console.WriteLine("--- LISTA ALUNOS ---");
            Utils.LerTxt(aluno1.alunoTxt);

            Console.WriteLine("--- LISTA PROFESSORES ---");
            Utils.LerTxt(professor1.professorTxt);

            Console.WriteLine("--- LISTA FORNECEDORES ---");
            Utils.LerTxt(fornecedor1.fornecedorTxt);

            Console.ReadKey();
        }
    }
}
