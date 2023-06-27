using Sentence_Reversal.Interfaces;

namespace Sentence_Reversal.Services
{
    public class CaseNumberParser : ICaseNumberParser
    {
       public bool ParseNumberOfCases(string numberOfCases, out int parsedNumberofCases) =>
				int.TryParse(numberOfCases , out parsedNumberofCases);
    }   
}