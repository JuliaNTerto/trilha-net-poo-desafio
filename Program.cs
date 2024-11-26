using DesafioPOO.Models;

using DesafioPOO.Models;

// Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smatphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo-01", imei: "1111-KKK", memoria: 64);
nokia.ExibirInfo();
nokia.Ligar();
nokia.InstalarAplicativo("GitHub");
Console.WriteLine();
Console.WriteLine("DADOS DO PROXIMO APARELHO:");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "2024PTBR", modelo: "Modelo-Pro", imei: "46656", memoria: 512);
iphone.ExibirInfo();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Github");
 