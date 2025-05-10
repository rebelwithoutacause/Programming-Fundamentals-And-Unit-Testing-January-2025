using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class PalindromeIntegersTests
{
    PalindromeIntegers pi;
    [SetUp]

    public void Setup() 
    {
       pi = new PalindromeIntegers();
    }

    [Test]
    public void Test_FindPalindromes_EmptyList_ReturnsEmptyList()
    {
        //Arrange
        List<int> numbers = new();

        //Act
        
        List<int>result = pi.FindPalindromes(numbers);

        //Assert
        Assert.That(result, Is.Empty);
       
        
    }

    [Test]
    public void Test_FindPalindromes_NoPalindromes_ReturnsEmptyList()
    {

        //Arrange
        List<int> numbers = new() { 661, 251, 2001, 321 };

        //Act

        List<int> result = pi.FindPalindromes(numbers);

        //Assert
        Assert.That(result, Is.Empty);


    }

    [Test]
    public void Test_FindPalindromes_OnlySingleDigitsElements_ReturnsSameIntegersList()
    {
        //Arrange
        List<int> numbers = new() { 3, 5, 6, 8 };
        
        //Act
        
        List<int> result = pi.FindPalindromes(numbers);

        //Assert
        Assert.That(result, Is.EqualTo(numbers));
    }

    [Test]
    public void Test_FindPalindromes_AllElementsArePalindromes_ReturnsSameIntegersList()
    {
        List<int> numbers = new() { 3003, 505, 666, 808 };

        //Act

        List<int> result = pi.FindPalindromes(numbers);

        //Assert
        Assert.That(result, Is.EqualTo(numbers));
    }

    [Test]
    public void Test_FindPalindromes_PalindromesAndNoPalindromesIntegers_ReturnsOnlyPalindromes()
    {
        List<int> numbers = new() { 666, 251, 2002, 321 };
        List<int> expected = new() { 666, 2002 };

        List<int> result = pi.FindPalindromes(numbers);

        CollectionAssert.AreEqual(expected, result);
    }
}
