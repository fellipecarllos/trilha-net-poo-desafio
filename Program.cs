using DesafioPOO.Models;

Console.Clear();

Console.WriteLine("Smartphone NOKIA");
Smartphone nokia = new Nokia(numero: "4878742", modelo: "NOKIA", imei: "35847812002121", memoria: 256);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "88789005", modelo: "Iphone 15", imei: "987712560650", memoria: 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");