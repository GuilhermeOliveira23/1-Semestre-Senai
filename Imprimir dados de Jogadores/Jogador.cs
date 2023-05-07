using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imprimir_dados_de_Jogadores
{
    public  abstract class Jogador
    {
    //  1.Crie uma classe abstrata para representar um jogador de futebol, com os atributos nome, data de nascimento, nacionalidade, altura e peso. Crie um método para imprimir todos os dados do jogador. Crie um método para calcular a idade do jogador e outro método para mostrar quanto tempo falta para o jogador se aposentar. Para isso, crie outras 3 subclasses, JOGADORDEFESA, JOGADORATAQUE e JOGADORMEIO-CAMPO considere que os jogadores da posição de defesa se aposentam em média aos 40 anos, os jogadores de meio-campo aos 38 e os atacantes aos 35.

    public string nome { get; set; }
    public string datadenascimento { get; set; }
    public string nacionalidade { get; set; }
    public float altura { get; set; }
    public float peso { get; set; }
    public int idade { get; set; }
    public void ImprimirDados(string nome, string datadenascimento, string nacionalidade, float altura, float peso, int idade){

    Console.WriteLine($"Nome: {nome}");
    Console.WriteLine($"Data de nascimento: {datadenascimento}");
    Console.WriteLine($"Nacionalidade: {nacionalidade}");
    Console.WriteLine($"Altura: {altura}");
    Console.WriteLine($"Peso: {peso}");
    Console.WriteLine($"Idade: {idade}");
    


    }

   
    }

    public class JogadorDefesa : Jogador{

    public int calcularIdade(int idade){

       return 40 - idade;

    }
    public void TempoAposentar(int resultado) {
        Console.WriteLine($"Faltam {resultado} anos para o jogador aposentar");
        
    }
    
    }
    public class JogadorAtaque : Jogador{

    public int calcularIdade(int idade){

        return 35 - idade;
        

    }
    public void TempoAposentar(int resultado) {
Console.WriteLine($"Faltam {resultado} anos para o jogador aposentar");
    }
    
    }
    public class JogadorMeio_Campo : Jogador{
    public int calcularIdade(int idade){

        return 38 - idade;

    }

    public void TempoAposentar(int resultado) {
Console.WriteLine($"Faltam {resultado} anos para o jogador aposentar");
    }
    

    }




}