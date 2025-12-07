namespace DictionaryCountryCapital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> capitals = new Dictionary<string, string>();
            capitals["Bulgaria"] = "Sofia";
            capitals["Malta"] = "La Valetta";
            capitals["Spain"] = "Madrid";
            capitals["Denmark"] = "Copenhagen";
            capitals["Sweden"] = "Stockholm";
            capitals["Norway"] = "Oslo";         //This is for Task 8 in the Homework

            foreach (var pair in capitals)
            {
                string capital = capitals[pair.Key];
                Console.WriteLine(capital); // This is for Task 9 in the Homework
            }

            foreach (var pair in capitals)
            {
                Console.WriteLine(pair.Key + " - " + pair.Value); // This is for Task 10 in the Homework
            }

        }
    }
}
