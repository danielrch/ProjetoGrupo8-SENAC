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
            // CRIANDO PESSOAS COM OS DADOS PEDIDOS NO CONSTRUTOR COMPLETO, OU SEJA, COM ENDEREÇO
            //Aluno aluno1 = new Aluno("Física", "Daniel", "151589115491", "11989122222", "daniel@gmail.com", "Rua Maria Campos", "125", "06316123", "São Paulo", "Luz", "SP");
            //Professor professor1 = new Professor("Física", "Tiago", "515915915915", "11989111111", "tiago@gmail.com", "Rua Maria Campos", "125", "06316123", "São Paulo", "Luz", "SP");
            //Fornecedor fornecedor1 = new Fornecedor("Jurídica", "Anilton", "151589115491", "11989122222", "anilton@gmail.com", "Rua Maria Campos", "125", "06316123", "São Paulo", "Luz", "SP");

            //CRIANDO PESSOAS COM OS DADOS PEDIDOS NO CONSTRUTOR SIMPLES, SEM ENDEREÇO
            //Fornecedor fornecedor1 = new Fornecedor("Jurídica", "Anilton", "151589115491", "11989122222", "anilton@gmail.com");
            //Professor professor1 = new Professor("Física", "Tiago", "515915915915", "11989111111", "tiago@gmail.com");
            Aluno aluno1 = new Aluno("Física", "Daniel", "151589115491", "11989122222", "daniel@gmail.com");
            Aluno aluno2 = new Aluno("Física", "Rodrigo", "151589115491", "11989122222", "daniel@gmail.com");
            Aluno aluno3 = new Aluno("Física", "Tiago", "151589115491", "11989122222", "daniel@gmail.com");
            Aluno aluno4 = new Aluno("Física", "Kali", "151589115491", "11989122222", "kali@gmail.com");

            // CADASTRANDO A PESSOA EM UMA LISTA E GERANDO O TXT - MÉTODO ESTÁ DENTRO DO CADASTRARPESSOA()
            aluno1.CadastrarPessoa(aluno1);
            aluno2.CadastrarPessoa(aluno2);
            aluno3.CadastrarPessoa(aluno3);
            aluno4.CadastrarPessoa(aluno4);
            //professor1.CadastrarPessoa(professor1);
            //fornecedor1.CadastrarPessoa(fornecedor1);

            // RESGATANDO O CONTEÚDO DO TXT E EXIBINDO NO CONSOLE
            Console.WriteLine("--- LISTA ALUNOS ---");
            Utils.LerTxt(aluno1.alunoTxt);

            //Console.WriteLine("--- LISTA PROFESSORES ---");
            //Utils.LerTxt(professor1.professorTxt);

            //Console.WriteLine("--- LISTA FORNECEDORES ---");
            //Utils.LerTxt(fornecedor1.fornecedorTxt);

            Console.ReadKey();
        }
    }
}
