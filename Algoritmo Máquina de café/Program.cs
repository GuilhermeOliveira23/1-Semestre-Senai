
using Algoritmo_Máquina_de_café;
MaquinaCafe mc = new MaquinaCafe();


//  int? resultado1 = MaquinaCafe.StringToNullableInt(mc.quantidadeAcucar);



voltar:

Console.WriteLine($"Deseja fazer um café? [S/N]");
string cafe = Console.ReadLine().ToUpper();

Console.WriteLine($"Quer que ele seja com açucar ou sem açucar?  [Com/Sem]");
string opcaoAcucar = Console.ReadLine().ToUpper();

  if (opcaoAcucar == "COM")
  {
    Console.WriteLine($"Qual é a quantidade em gramas de açucar que deseja adicionar?");
    mc.quantidadeAcucar = Console.ReadLine()!;
    int QuantIntacucar = int.Parse(mc.quantidadeAcucar);
    

   if (mc.quantidadeAcucar == null)
   {
     QuantIntacucar = mc.FazerCafe(10, mc.acucarDisponivel);
   }
   
   

   QuantIntacucar = mc.FazerCafe(QuantIntacucar ,mc.acucarDisponivel);
  }
else{
    Console.WriteLine($"Fazendo café sem açucar...");
    goto voltar;
}

Console.WriteLine(mc.quantidadeAcucar);


// mc.FazerCafe();



