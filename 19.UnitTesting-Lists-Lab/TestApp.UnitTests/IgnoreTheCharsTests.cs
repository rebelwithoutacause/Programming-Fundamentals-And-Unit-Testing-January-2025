using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class IgnoreTheCharsTests
{
    [Test]
    public void Test_IgnoreChars_EmptyStringSentence_ReturnsEmptyString()
    {
        //Arrange
        string sentence = "";
        List<char> ignoreChars = new() { 'a',  'b' };

        //Act
        string result = IgnoreTheChars.IgnoreChars(sentence, ignoreChars);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_IgnoreChars_EmptyList_ReturnsSameSentence()
    {
        string sentence = "Timmy is 25 years old.";
        List<char> ignoreChars = new();

        //Act
        string result = IgnoreTheChars.IgnoreChars(sentence, ignoreChars);

        //Assert
        Assert.That(result, Is.EqualTo(sentence));
    }

    [Test]
    public void Test_IgnoreChars_OneCharSentenceAndSameCharsForIgnoring_ReturnsEmptyString()
    {
        string sentence = "A";
        List<char> ignoreChars = new() { 'A' };

        //Act
        string result = IgnoreTheChars.IgnoreChars(sentence, ignoreChars);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_IgnoreChars_WholeSentenceAndFewCharsToIgnore_ReturnsCorrectString()
    {
        string sentence = "Timmy is 25 years old.";
        List<char> ignoreChars = new() { 'T', 'a', '.' };
        string expected = "immy is 25 yers old";
        

        //Act
        string result = IgnoreTheChars.IgnoreChars(sentence, ignoreChars);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
