using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class CenterPointTests
{
    [Test]
    public void Test_GetClosest_WhenFirstPointIsCloser_ShouldReturnFirstPoint()
    {
        // Arrange
        double x1 = 1;
        double y1 = 2;
        double x2 = 2;
        double y2 = 1;
        string expected = "(1, 2)";

        string result = CenterPoint.GetClosest(x1, y1, x2, y2);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsCloser_ShouldReturnSecondPoint()
    {
        double x1 = 2;
        double y1 = 3;
        double x2 = 2;
        double y2 = 1;
        string expected = "(2, 1)";

        string result = CenterPoint.GetClosest(x1, y1, x2, y2);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetClosest_WhenBothPointsHaveEqualDistance_ShouldReturnFirstPoint()
    {
        double x1 = 2;
        double y1 = 3;
        double x2 = 3;
        double y2 = 2;
        string expected = "(2, 3)";

        string result = CenterPoint.GetClosest(x1, y1, x2, y2);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetClosest_WhenFirstPointIsNegative_ShouldReturnFirstPoint()
    {
        double x1 = -2;
        double y1 = -3;
        double x2 = 2;
        double y2 = 1;
        string expected = "(2, 1)";

        string result = CenterPoint.GetClosest(x1, y1, x2, y2);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsNegative_ShouldReturnSecondPoint()
    {
        double x1 = -1;
        double y1 = -1;
        double x2 = -1;
        double y2 = 1;
        string expected = "(-1, 1)";

        string result = CenterPoint.GetClosest(x1, y1, x2, y2);

        Assert.That(result, Is.EqualTo(expected));
    }
}
