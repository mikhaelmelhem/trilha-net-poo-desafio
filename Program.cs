using DesafioPOO.Models;

System.Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Lumia", imei: "123456789", memoria: 256);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

System.Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "123456", modelo: "Lumia", imei: "123456789", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");