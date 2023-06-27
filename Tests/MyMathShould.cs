using NUnit.Framework;
using Core;

namespace Tests;

public class MyMathShould
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AddTwoNumbers()
    {
        var adder = new MyMath();
        Assert.AreEqual(3, adder.Add(1, 2));
    }
}
