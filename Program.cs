using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Celular Nokia: ");
Smartphone nokia = new Nokia(numero: "123456", modelo: "n95", imei: "789", memoria: 555);
nokia.Ligar();
nokia.InstalarAplicativo("Inatagram");

Console.WriteLine("Celular Iphone: ");
Smartphone iphone = new Iphone(numero: "94561", modelo: "15 pro", imei: "8526", memoria: 444);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");