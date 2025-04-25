var titular = new Titular("Lucas Araújo", "123.456.789-00", "Rua das Flores, 123");
var conta = new Conta(titular, 1234, 567890, 1500.00, 500.00);

Console.WriteLine(conta.Informacoes);