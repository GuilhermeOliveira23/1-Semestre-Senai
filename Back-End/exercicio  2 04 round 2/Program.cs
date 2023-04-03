 int incrementoPositivo = 0;
 
 Console.WriteLine($"PErgunta 1");
string resposta1 = Console.ReadLine().ToUpper();

 Console.WriteLine($"PErgunta 2");
 string resposta2 = Console.ReadLine().ToUpper();

 Console.WriteLine($"PErgunta 3");
string resposta3 = Console.ReadLine().ToUpper();
 Console.WriteLine($"PErgunta 4");
string resposta4 = Console.ReadLine().ToUpper();
 Console.WriteLine($"PErgunta 5"); 
 string resposta5 = Console.ReadLine().ToUpper();
 
 if(resposta1 =="SIM") {   incrementoPositivo ++;}
 if(resposta2 =="SIM") {   incrementoPositivo ++;}
 if(resposta3 =="SIM") {   incrementoPositivo ++;}
 if(resposta4 =="SIM") {   incrementoPositivo ++;}
 if(resposta5 =="SIM") {   incrementoPositivo ++;}

 if(incrementoPositivo == 2){
    Console.WriteLine($"Você é suspeito");
    

 }
 if(incrementoPositivo == 3 || incrementoPositivo == 4 ){
    Console.WriteLine($"Você é cumplice");
    

 }
 if(incrementoPositivo == 5){
    Console.WriteLine($"Você é culpado");
    

 }
 if(incrementoPositivo == 0 || incrementoPositivo == 1){
    Console.WriteLine($"Você é inocente");
    

 }
 
