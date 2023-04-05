
 bool cadastro =  false;
 bool cadastro1 =  false;
 bool cadastro2 =  false;
 bool cadastro3 =  false;



do{
    Console.WriteLine($"Digite o seu nome:");
 string nome =  Console.ReadLine()!;
    if(!(nome == "")){
        
        cadastro = true;
        
    }
    else{
    Console.WriteLine($"Nome inválido");
    
}
    
    
    
} while(cadastro == false);



do{
    Console.WriteLine($"Digite a sua idade:");
 int idade =  int.Parse(Console.ReadLine()!);
    if((idade <=100 && idade>=0 )){
        
        cadastro1 = true;
        
    }
    else{
    Console.WriteLine($"Idade inválida");
    
}
    
    
    
} while(cadastro1 == false);

do{
    Console.WriteLine($"Digite o seu salário:");
 int salario =  int.Parse(Console.ReadLine()!);
    if((salario > 0)){
        
        cadastro2 = true;
        
    }
    else{
    Console.WriteLine($"Salário inválido");
    
}
    
    
} while(cadastro2 == false);

do{
    Console.WriteLine($"Digite o seu estado civil:");
  char estadoCivil =  char.Parse(Console.ReadLine()!.ToUpper());
    if(estadoCivil == 'C'||estadoCivil == 'S'||estadoCivil == 'V'||estadoCivil == 'D'){
        Console.WriteLine($"Dados Registrados com êxito");
        cadastro3 = true;
        
    }
    else{
    Console.WriteLine($"Estado civil inválido");
    
}
    

    
} while(cadastro3 == false);





