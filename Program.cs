//Caixa Eletrônico

string cpf = "123456";
string senha = "012345";

string? cpf_digitado = "";
string? senha_digitada = "";

decimal saldo = 1000.00m;

Console.WriteLine("---Caixa Eletrônico---");
Console.WriteLine("");
while(cpf_digitado != cpf)
{
    Console.WriteLine("Os 6 primeiros digitos do seu CPF: ");
    cpf_digitado = Console.ReadLine();

    if(cpf_digitado != cpf){
    Console.WriteLine("CPF invalido! ");
    }
}
for (int i = 1; i <= 3; i++) 
{
    Console.WriteLine("Senha de 6 digitos: ");
    senha_digitada = Console.ReadLine();
    
    if (senha_digitada != senha)
    {
        Console.WriteLine("Senha incorreta! ");
        Console.WriteLine($"Tentativas restantes: {3 - i}");
    }
    else
    {
        Console.WriteLine("Entrando... ");
        Console.WriteLine("---Bem-Vindo---");
        Console.WriteLine("");

int op = 1;

while (op != 0)
{
    Console.WriteLine("1 - Consultar saldo");
    Console.WriteLine("2 - Depositar");
    Console.WriteLine("3 - Sacar");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("Escolha a opção: ");
    op = int.Parse(Console.ReadLine()!);

    switch (op) 
    {
        case 1:
        Console.WriteLine("");
        Console.WriteLine($"Seu saldo é: R${saldo:F2}");
        break;

        case 2:
        Console.WriteLine("");
        Console.WriteLine("Qual valor do deposito: ");
        decimal deposito = decimal.Parse(Console.ReadLine()!);
        Console.WriteLine("");
        if (deposito <= 0)
                    {
                        Console.WriteLine("Não é possível depositar um valor negativo! ");
                    }
        else
                    {
                        saldo += deposito;
                        Console.WriteLine($"Saldo atual é de: R${saldo:F2}");
                        Console.WriteLine("");
                    }
        break;

        case 3:
        Console.WriteLine("");
        Console.WriteLine("Qual valor do saque: ");
        decimal saque = decimal.Parse(Console.ReadLine()!);
        Console.WriteLine("");
        if (saque <= 0)
                    {
                        Console.WriteLine("Não é possível sacar um valor negativo! ");
                    }
        else if (saque > saldo)
            {
                Console.WriteLine("Saldo insuficiente ");
                Console.WriteLine("");
            }
        else
            {
                saldo -= saque;
                Console.WriteLine($"Seu saldo atual é de: R${saldo:F2}");
                Console.WriteLine("");
            }
        break;

        case 0:
        Console.WriteLine("");
        Console.WriteLine("Encerrando...");
        break;

                default:
                Console.WriteLine("Opção invalida! ");
                break;
    }
}
        break;
    }
}



