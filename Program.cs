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
            capitals["Norway"] = "Oslo";

            foreach (var pair in capitals) { 
            Console.WriteLine(pair.Key + " - " + pair.Value);
            }

        }
    }
}
