namespace Sentence_Reversal.Extensions
{
    public static class StringExtensions {
        public static string ToCase(this string sentence, int caseIndex)
            => $"Case {caseIndex} : {sentence}";
    }
}