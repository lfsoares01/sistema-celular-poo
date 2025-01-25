using DesafioPOO.Models;

Smartphone iphone1 = new Iphone("0101", "Iphone8", "333353", "64GB" );
iphone1.InstalarAplicativo("JW", modelo: "Iphone8");
iphone1.Ligar();
iphone1.ReceberLigacao();// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia1 = new Nokia("0222", "NokiaG3", "54657", "128GB" );
nokia1.InstalarAplicativo("Maps",modelo: "NokiaG3");
nokia1.Ligar();
nokia1.ReceberLigacao();

