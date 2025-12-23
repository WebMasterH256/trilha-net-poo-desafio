using DesafioPOO.Models;

Nokia Lumia = new Nokia("123456789", "Lumia", "987654321abcdef", 1);
Iphone Xr = new Iphone("987654321", "XR", "123456abcdef", 4);

Console.WriteLine($"Os modelos Nokia e Iphone tem respectivamente: {Lumia.ToString}, {Xr.ToString}");

Console.Write("Ligando do Nokia: "); Lumia.ReceberLigacao();
Console.Write("Ligando do Iphone: "); Xr.ReceberLigacao();

Console.WriteLine("Instalando aplicativos: ");
Console.WriteLine($"Iphone: {Xr.InstalarAplicativo}");
Console.WriteLine($"Nokia: {Lumia.InstalarAplicativo}");
