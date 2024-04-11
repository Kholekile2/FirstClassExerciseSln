namespace FirstClassExercise
{
    internal class Program
    {
      public static string ReverseString(string forwardText)
        {
            
            string containerText = "";

            for (int i = forwardText.Length - 1; i >= 0; i--)
            {
                containerText += forwardText[i];
            }

            return containerText;

        }
        static void Main(string[] args)
        {
            string reversedString = ReverseString("Text to reverse.");

            Console.WriteLine("Output: " + reversedString);

        }
    }
}