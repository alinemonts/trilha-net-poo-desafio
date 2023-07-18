using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokiaC30 = new Nokia(numero:"41999595999", imei:"20365423012365", modelo:"C30", memoria:64);
Nokia nokiaC01 = new Nokia(numero:"41999576999", imei:"20369865412986", modelo:"C01", memoria:32);

Iphone iphone11 = new Iphone(numero:"41986954999", imei:"20369865458910", modelo:"iPhone 11", memoria:64);
Iphone iphone14 = new Iphone(numero:"41986954964", imei:"20369861254698", modelo:"iPhone 14", memoria:128);

nokiaC01.Ligar();
nokiaC01.ReceberLigacao();
nokiaC01.InstalarAplicativo("WhatsApp");
Console.WriteLine();

nokiaC30.Ligar();
nokiaC30.ReceberLigacao();
nokiaC30.InstalarAplicativo("WhatsApp");
Console.WriteLine();

iphone11.Ligar();
iphone11.ReceberLigacao();
iphone11.InstalarAplicativo("WhatsApp");
Console.WriteLine();

iphone14.Ligar();
iphone14.ReceberLigacao();
iphone14.InstalarAplicativo("WhatsApp");
Console.WriteLine();