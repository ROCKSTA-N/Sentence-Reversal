using Sentence_Reversal.Interfaces;
using System.Linq;

namespace Sentence_Reversal.Services
{
    public class SentenceReverser : ISentenceReverser
    {
       public string ReverseSentence(string sentence){
            var splitAndReversedSentence = sentence.Split(' ').Reverse();
            return string.Join(" ", splitAndReversedSentence);
       }
    }   
}