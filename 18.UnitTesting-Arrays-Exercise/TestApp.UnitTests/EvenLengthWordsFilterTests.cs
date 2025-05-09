using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class EvenLengthWordsFilterTests
{
    [Test]
    public void Test_GetEvenWords_InputArrayWithEmptyStrings_ShouldReturnEmptyString()
    {
        string[] inputArray = Array.Empty<string>();
        string expected = string.Empty;

        string actual = EvenLengthWordsFilter.GetEvenWords(inputArray);
        
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithOneOddLengthWord_ShouldReturnEmptyString()
    {
        string[] inputArray = new string[] { "abc" };
        string expected = string.Empty;

        string actual = EvenLengthWordsFilter.GetEvenWords(inputArray);

        Assert.That(actual,Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenWords_InputArrayOnlyWithOddLengthWords_ShouldReturnEmptyString()
    {
        string[] inputArray = new string[] { "abc", "abcde" };
        string expected = string.Empty;  

        string actual = EvenLengthWordsFilter.GetEvenWords(inputArray);

        Assert.That(actual, Is.EqualTo(expected));  
    }


    [Test]
    public void Test_GetEvenWords_InputArrayWithOneEvenLengthWord_ShouldReturnSameWord()
    {
        string[] inputArray = new string[] { "abcd" };
        string expected = "abcd"; 

        string actual = EvenLengthWordsFilter.GetEvenWords(inputArray);

        Assert.That(actual, Is.EqualTo(expected));
    }
    [Test]
    public void Test_GetEvenWords_InputArrayWithEvenAndOddLengthWords_ShouldReturnOnlyEvenLengthWords()
    {
        string[] inputArray = new string[] { "abc", "abcd", "abcde", "abcdef" };
        string expected = "abcd abcdef"; 

        string actual = EvenLengthWordsFilter.GetEvenWords(inputArray);
        Assert.That(actual, Is.EqualTo(expected));
    }
}

