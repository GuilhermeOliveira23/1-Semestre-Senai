Console.WriteLine($" Por favor insira a quantidade de dias em que o aluno compareceu em aula:");
int dias = int.Parse(Console.ReadLine());
int porcentagem = (dias * 100)/200;





Console.WriteLine($"Esse aluno teve uma taxa de comparecimento de {(dias * 100)/200}%");
float media = float.Parse(Console.ReadLine());

if (porcentagem > 75 ) {

    Console.WriteLine($"Por favor insira a media do aluno");  
    

}

 

  else if( media > 7.0f)
{
    
       Console.WriteLine($"Você Foi APROVADOOOOO!!!!");
       
 }
else{
    Console.WriteLine($"Você foi reprovado!!!!!");
    
}

