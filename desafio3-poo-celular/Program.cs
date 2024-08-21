using DesafioPOO.Models;

Smartphone nokia = new Nokia(numero: "12345", modelo: "tijolo", imei: "111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Smartphone iphone = new Iphone(numero: "67890", modelo: "Iphone 15", imei: "999999", memoria: 256);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");