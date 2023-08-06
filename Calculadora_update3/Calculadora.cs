using System;

public class Calculadora
{
    private double numero1;
    private double numero2;
    private string operacao;

    public void Interface()
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine("       Calculadora em C#        ");
        Console.WriteLine("--------------------------------");
    }
    public double Numero1()
    {
        Console.WriteLine("Digite um número: ");
        numero1 = double.Parse(Console.ReadLine());
        return numero1;
    }
    public double Numero2()
    {
        Console.WriteLine("\nDigite outro número: ");
        numero2 = double.Parse(Console.ReadLine());
        return numero2;
    }

    public string Decisao()
    {
        Console.WriteLine("\nEscolha a opção que deseja usar");
        Console.WriteLine("Digite A para Somar");
        Console.WriteLine("Digite B para subtrair");
        Console.WriteLine("Digite C para multiplicar");
        Console.WriteLine("Digite D para dividir");

        Console.Write("\nAgora digite a operação que deseja adicionar: ");
        operacao = Console.ReadLine();
        return operacao;
    }

    public void ExibirMensagemDecisao(double number, double number2)
    {
        string exibirDecisao = Decisao();
        switch (exibirDecisao)
        {
            case "A":
                Console.WriteLine($"A soma entre o número {number} e o número {number2} é igual a " + (number + number2));
                break;
            case "B":
                Console.WriteLine($"A subtração entre o número {number} e o número {number2} é igual a " + (number - number2));
                break;
            case "C":
                Console.WriteLine($"A multiplicação entre o número {number} e o número {number2} é igual a " + (number * number2));
                break;
            case "D":
                Console.WriteLine($"A divisão entre o número {number} e o número {number2} é igual a " + (number / number2));
                break;
            default:
                Console.WriteLine("Operação inválida");
                break;
        }

    }

    public void Mensagem()
    {
        Interface();
        double exibirNumero1 = Numero1();
        double exibirNumero2 = Numero2();
        ExibirMensagemDecisao(exibirNumero1, exibirNumero2);
    }
}