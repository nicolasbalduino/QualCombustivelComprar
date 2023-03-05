internal class Program
{
    private static void Main(string[] args)
    {
        float precoAlcool, precoGasolina;

        Console.WriteLine("Informe o preco do alcool: ");
        precoAlcool = float.Parse(Console.ReadLine());

        Console.WriteLine("Informe o preco da gasolina: ");
        precoGasolina = float.Parse(Console.ReadLine());

        if (precoAlcool / precoGasolina <= 0.72)
            Console.WriteLine("Compre alcool");
        else
            Console.WriteLine("Compre Gasolina");
    }
}
