namespace HashMapTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash Map!!!");

            LinkedHashMap<string, int> hashMap = new LinkedHashMap<string, int>(5);
            //string sentence = "to be or not to be";
            string sentence = "Paranoids are not paranoid because they are paranoid but because they keep putting " +
                              "themselves deliberately into paranoid avoidable situations";

            string[] words = sentence.ToLower().Split(" ");
            foreach (var word in words)
            {
                int value=hashMap.Get(word);
                if (value == default)
                    value = 1;
                else
                    value += 1;
                hashMap.Add(word, value);
            }

            //string key = "to";
            string key = "paranoid";
            int wordFrequency = hashMap.Get(key);
            Console.WriteLine($"Frequency of word {key} in sentence is {wordFrequency}");
        }
    }
}