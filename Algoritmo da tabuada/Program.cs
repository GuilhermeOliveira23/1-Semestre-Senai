




int tabuadaValor = 0;
do{

    Console.WriteLine($"Tabuada do {tabuadaValor} :");
    
for (int i = 0; i < 10; i++)
{
    
    Console.WriteLine($"{tabuadaValor} x {i+1} = {tabuadaValor * (i+1)}");

    
}   
Console.WriteLine("");

   tabuadaValor ++; 
}while(tabuadaValor != 11);






