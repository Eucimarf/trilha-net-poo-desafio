using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Testando funcionamento do Nokia:");

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "8597445680", modelo: "Nokia X", imei: "85749632157", memoria: 256);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Youtube");

Console.WriteLine("\n...Trocando o teste para Iphone:");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "8596534120", modelo: "Iphone 15", imei: "9856321478", memoria: 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
iphone.Ligar();
iphone.InstalarAplicativo("Snapchat");