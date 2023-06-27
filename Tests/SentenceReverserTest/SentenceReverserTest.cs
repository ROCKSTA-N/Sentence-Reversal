using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Sentence_Reversal.Interfaces;
using Sentence_Reversal.Services;
using Moq;
using FluentAssertions;

namespace Tests.SentenceReverserTest
{
    public class SentenceReverserTest
    {
        private ISentenceReverser sentenceReverser;

        [SetUp]
        public void Setup()
        {
            sentenceReverser = new SentenceReverser();
        }

        [Test]
        public void Test_ISentenceReverser_When_This_Is_test_Return_Test_is_This()
        {            
            var reversed = sentenceReverser.ReverseSentence("This is test");   
            var expected  = "test is This";        
            reversed.Should().Be(expected);
        }

        [Test]
        public void Test_ISentenceReverser_When_String_Empty_Return_String_Empty()
        {            
            var reversed = sentenceReverser.ReverseSentence(string.Empty);   
            var expected  = string.Empty;        
            reversed.Should().Be(expected);
        }
    }
}