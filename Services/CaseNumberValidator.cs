using Sentence_Reversal.Interfaces;

namespace Sentence_Reversal.Services
{
    public class CaseNumberValidator : ICaseNumberValidator
    {
       public bool ValidateCaseNumber(int numberOfCases) => numberOfCases is > 0 and < 26;
    }   
}