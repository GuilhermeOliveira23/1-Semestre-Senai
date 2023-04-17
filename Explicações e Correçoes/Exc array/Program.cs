int []numInt = new int [5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Informe o {i + 1}º numero:");
  numInt[i] = int.Parse(Console.ReadLine()!);
}

foreach (int item in numInt)
{
    Console.WriteLine($"O valor é : {item * 2}");
    
    
    
}
