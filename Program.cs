namespace csharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-- PROGRAMA DO AÇAÍ --");

        Console.WriteLine("Informe a quantidade de açaís pequenos:");
        string qtdAcaiPequeno = Console.ReadLine();

        Console.WriteLine("Informe a quantidade de açaís médios:");
        string qtdAcaiMedio = Console.ReadLine();

        Console.WriteLine("Informe a quantidade de açaís grandes:");
        string qtdAcaiGrande = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(qtdAcaiPequeno)) qtdAcaiPequeno = "0";
        if (string.IsNullOrWhiteSpace(qtdAcaiMedio)) qtdAcaiMedio = "0";
        if (string.IsNullOrWhiteSpace(qtdAcaiGrande)) qtdAcaiGrande = "0";

        double TotalAcaiPequenoConv = Convert.ToDouble(qtdAcaiPequeno);
        double TotalAcaiMedioConv = Convert.ToDouble(qtdAcaiMedio);
        double TotalAcaiGrandeConv = Convert.ToDouble(qtdAcaiGrande);

        double PrecoFinal = TotalAcaiPequenoConv * 13 + TotalAcaiMedioConv * 15 + TotalAcaiGrandeConv * 17.50;

        Console.WriteLine($"Compra finalizada! Total a ser pago R${PrecoFinal}.");
    }
}