using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Sentence_Reversal.Interfaces;
using Sentence_Reversal.Services;
using Moq;
using FluentAssertions;


namespace Tests.CaseNumberParserTest
{
    public class CaseNumberParserTests
    {
         private ICaseNumberParser caseNumberParser;

        [SetUp]
        public void Setup()
        {
            caseNumberParser = new CaseNumberParser();
        }

        [Test]
        public void Test_CaseNumberParser_When_Given_A_validNumber_Return_true()
        { 
           var isvalid = caseNumberParser.ParseNumberOfCases("5", out var numberOfCases);
           isvalid.Should().Be(true);
        }

        [Test]
        public void Test_CaseNumberParser_When_Given_Ten_Return_10()
        { 
           var isvalid = caseNumberParser.ParseNumberOfCases("10", out var numberOfCases);
           numberOfCases.Should().Be(10);
        }

        [Test]
        public void Test_CaseNumberParser_When_Given_A_InvalidNumber_Return_False()
        { 
           var isvalid = caseNumberParser.ParseNumberOfCases("PPP", out var numberOfCases);
           isvalid.Should().Be(false);
        }
    }
}