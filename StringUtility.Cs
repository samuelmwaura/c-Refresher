namespace fundamentals
{
    public class StringUtility
    {
        public static string SummarizeSentence(string sentence,int summarysize)
        {
            if (sentence.Length <= summarysize)
            return sentence;

            string[] words = sentence.Split(" ");
            List<string> wordsList = new List<string>();
            int totalCharacters = 0;

            foreach (var word in words)
            {
                wordsList.Add(word);
                totalCharacters += word.Length + 1; // Account for space
                if (totalCharacters > summarysize)
                {
                    return String.Join(" ",wordsList) + "...";
                }

            }



            return string.Format(sentence, sentence, summarysize);

        }
    }

}