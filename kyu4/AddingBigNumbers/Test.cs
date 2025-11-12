using Kyu4AddingBigNumbers;

namespace AddingBigNumbersTest;

// NUnit Test
public class Tests
{
    [Test]
    public void Test1()
    {
        Assert.That(Kata.Add("91", "19"), Is.EqualTo("110"));
        Assert.That(Kata.Add("123456789", "987654322"), Is.EqualTo("1111111111"));
        Assert.That(Kata.Add("999999999", "1"), Is.EqualTo("1000000000"));
    }
}