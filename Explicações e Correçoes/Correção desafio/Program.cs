
int[] numeros = new int[6];

for (int i = 0; i < 6; i++)
{
    Console.WriteLine($"{i+ 1}º Numero:");
 numeros[i] = int.Parse(Console.ReadLine()!);

 if(numeros[i] % 2 == 0){

    Console.WriteLine($"É par");
    
 }
 else{
    Console.WriteLine($"É impar");
    
 }
 
    
}