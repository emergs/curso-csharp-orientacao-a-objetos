Titular titular = new Titular("Emerson", "012.789.987.00", "Rua da Esperança, 255");
Conta conta = new Conta(titular, 3006, 12345, 5000, 1000);

System.Console.WriteLine($"Titular: {conta.Titular.Nome}");
System.Console.WriteLine($"Agencia: {conta.Agencia}");
System.Console.WriteLine($"Conta: {conta.NumeroDaConta}");
System.Console.WriteLine($"Saldo: {conta.Saldo}");
System.Console.WriteLine($"Limite: {conta.Limite}");

