using DesafioPOO.Models;

Iphone iphone = new Iphone("11999999999", "Iphone99", "IMEIAPPLE", 128);
iphone.InstalarAplicativo("Facebook");
iphone.Ligar();
iphone.ReceberLigacao();

Nokia nokia = new Nokia("119888888888", "Nokia24", "IMEINOKIA", 256);
nokia.InstalarAplicativo("Instagram");
nokia.Ligar();
nokia.ReceberLigacao();