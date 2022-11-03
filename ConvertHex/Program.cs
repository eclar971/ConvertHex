using System.Text;

namespace ConvertHex
{
    class Porgram
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a sentence of phrase");
            string ui = Console.ReadLine().ToLower();
            byte[] bytes = Encoding.UTF8.GetBytes(ui);
            string hexUi = BitConverter.ToString(bytes);
            Console.WriteLine(hexUi.Replace("-"," "));
        }
    }
}

