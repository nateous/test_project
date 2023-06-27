using NUnit.Framework;
using Core;

namespace Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var adder = new Class1();
        Assert.AreEqual(3, adder.Add(1, 2));
    }
}