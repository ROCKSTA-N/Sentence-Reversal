namespace Sentence_Reversal.Interfaces
{
    public interface ICaseNumberParser
    {
        bool ParseNumberOfCases(string numberOfCases, out int parsedNumberofCases);
    }   
}