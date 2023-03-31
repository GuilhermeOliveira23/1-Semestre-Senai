Console.WriteLine($"Insira a quantidade de dias que o aluno compareceu;");

int dias = int.Parse(Console.ReadLine());
int frequencia = ((dias * 100)/200);
int media = 0;

if (frequencia > 75){

Console.WriteLine($"Digite a media do aluno");

media = int.Parse(Console.ReadLine());

}

if (media < 7){
  Console.WriteLine($"Você foi reprovado!");
  
}
else {
  Console.WriteLine($"Você Passou!!!");
  
}






    
 