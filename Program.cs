using DesafioPOO.Models;

// Implementado: Realizar os testes com as classes Nokia e Iphone

Iphone iphone = new Iphone("1234", "Iphone-14", "imei-8908", 128);
Nokia nokia = new Nokia("4321", "Nokia-5310", "imei-4561", 128);

Console.WriteLine("Smartphone Iphone");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Reddit");

Console.WriteLine("");

Console.WriteLine("Smartphone Nokia");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Nubank");