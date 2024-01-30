using System.ComponentModel;


// TODO: Realizar os testes com as classes Nokia e Iphone

using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "991999999", modelo: "2280", imei: "123456789", memoria: 1);
nokia.ExibirDados();
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Trail Biker");
nokia.Numero = "991299999";
nokia.ExibirDados();

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone (numero: "981899999", modelo: "5", imei: "456789123", memoria: 16);
iphone.ExibirDados();
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Mario Kart Tour");