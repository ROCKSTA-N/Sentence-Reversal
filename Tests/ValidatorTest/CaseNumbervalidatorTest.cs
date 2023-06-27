using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Sentence_Reversal.Interfaces;
using Sentence_Reversal.Services;
using Moq;

namespace Tests.ValidatorTest
{
    public class CaseNumbervalidatorTest
    {
        private ICaseNumberValidator caseValidator;

        [SetUp]
        public void Setup()
        {
            caseValidator = new CaseNumberValidator();
        }

        [Test]
        public void Test_ICaseNumberValidator_When_numberValid_Return_True()
        {            
            var validationStatus = caseValidator.ValidateCaseNumber(5);            
            Assert.True(validationStatus);
        }

        [Test]
        public void Test_ICaseNumberValidator_When_numberInvalid_Return_False()
        { 
            var validationStatus = caseValidator.ValidateCaseNumber(27);            
            Assert.False(validationStatus);
        }

        [Test]
        public void Test_ICaseNumberValidator_When_Zero_Return_False()
        { 
            var validationStatus = caseValidator.ValidateCaseNumber(0);            
            Assert.False(validationStatus);
        }
    }
}