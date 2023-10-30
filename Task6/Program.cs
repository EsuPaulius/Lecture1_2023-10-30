namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vardas = "Paulius";
            int amzius = 28;
            string pareigos = "Developer";

            string text = $"""
                ==========VIZITINE==========
                Vardas: {vardas}
                Amzius: {amzius}
                Pareigos: {pareigos}
                ============================
                """;

            Console.WriteLine(text);

            Console.ReadLine();
        }
    }
}