using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Classe Iphone, testes: ");
var iphone = new Iphone("81991842513", "Modelo Iphone 1", "1111-9999", 32);
iphone.Numero = "777777777";
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Classe Nokia, testes: ");
var nokia = new Nokia("999999999", "Modelo Nokia 1", "4444-5555", 16);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");