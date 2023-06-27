using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Sentence_Reversal.Extensions;
using FluentAssertions;

namespace Tests.ExtensionsTest
{
    public class StringExtensionsTests
    {
        [Test]
        public void Test_StringExtensions_Given_ThisIsTest_1_return_case_1_ThisIstest()
        {
            var sentence = "This is Test";
            var index = 1;
            var expected = $"Case {index} : {sentence}";

            var output = sentence.ToCase(index);

             output.Should().Be(expected);
        }
    }
}