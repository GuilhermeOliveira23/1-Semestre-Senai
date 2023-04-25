using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// Nesta aula vamos fazer um pequeno sistema de cadastro de alunos, em um projeto de console no VsCode.
// Vamos desenvolver um programa que cadastre e mostre os dados de um aluno.
// Crie uma classe Aluno com as seguintes propriedades:
// Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 
// Também teremos os métodos: 
// VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.
// obs:
// bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade.
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade.
// outros casos a mensalidade será integral
// Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.
// Acrescente o que achar necessário.
namespace Sistema_Orientado_a_objeto
{
    public class Aluno
    {
        public string nome = "";
        public string curso = "";
        public int idade = 0;
        public string Rg = "";
        public bool bolsista = false;
        public int media = 0;
        public float valorMensalidade = 0f;

    public static bool VerMediaFinal(int a, bool b){
     b = a >6? true: false;
      return b;


    }
    public static float VerMensalidade(float a, float b){
   float resultado = a * b;
   return resultado;


    }

    }
}


