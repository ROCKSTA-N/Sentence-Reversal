using System;
using Sentence_Reversal.Extensions;
using Sentence_Reversal.Interfaces;
using Sentence_Reversal.Services;
using System.Collections.Generic;

namespace Sentence_Reversal
{
    class Program
    {
        static void Main(string[] args)
        {
            ICaseNumberParser caseNumberParser = new CaseNumberParser();
            ICaseNumberValidator caseNumberValidator = new CaseNumberValidator();
            ISentenceReverser reverser = new SentenceReverser();

            // read the first input : this wil determine how many time we loop
            var numberOfInputCases = Console.ReadLine();
            
            //parse the string to int and validate that the number is between 1 and 25
            if(caseNumberParser.ParseNumberOfCases(numberOfInputCases , out var numberOfCases) 
                    && caseNumberValidator.ValidateCaseNumber(numberOfCases)) {

                    var cases = new List<string>();

                    while (numberOfCases > 0){

                        // read user sentence
                        var inputSentence = Console.ReadLine();
                        
                        //declare case index and format string to reversed case
                        var caseIndex = cases.Count + 1;
                        var FormattedCase = reverser.ReverseSentence(inputSentence).ToCase(caseIndex);
                
                        // add case to cases list
                        cases.Add(FormattedCase);

                        //reduces the number of cases
                        numberOfCases--;
                    }

                    foreach (var sentence in cases) 
                        Console.WriteLine(sentence);

                    Console.Read();
            }
        }
    }
}
