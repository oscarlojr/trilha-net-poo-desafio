using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone");
Smartphone iphone  = new Iphone("123456876", "Modelo 1", "1234", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("TodoList");

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("865213561", "Modelo 2", "65346", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Pomodoro");