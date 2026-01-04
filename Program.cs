using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone ip1 = new Iphone("92584-8541", "Iphone 20", "55515635544sdsdds", 254);
Nokia nk1 = new Nokia("96325-4125", "Nokia 2003", "654987fvdvfd", 118);

//Iphone

Console.WriteLine($"IPHONE: {ip1.Numero}");
ip1.InstalarAplicativo("Duolingo");
ip1.Ligar();


Console.WriteLine();
//Nokia

Console.WriteLine($"NOKIA: {nk1.Numero}");
nk1.InstalarAplicativo("Facebook Lite");
nk1.ReceberLigacao();
