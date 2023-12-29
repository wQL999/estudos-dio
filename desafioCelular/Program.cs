using desafioCelular.Models;

Smartphone cell1 = new Nokia("12345", "model1", "1111111", 64);
Smartphone cell2 = new Iphone("33333", "model3", "55555555", 128);

Console.WriteLine("NOKIA:");

cell1.ligar();
cell1.receberLigacao();
cell1.installApp("Clash of Clans");
cell1.exibirInfos();

System.Console.WriteLine("");

System.Console.WriteLine("IPHONE: ");

cell2.ligar();
cell2.receberLigacao();
cell2.installApp("Clash Royale");