using LABA2;
using NUnit.Framework.Interfaces;
namespace Tests;

public class Tests
{
    private Taylor obj;
    [SetUp]
    public void Setup()
    {
        obj = new Taylor();
    }

    [TestCase(-1.8408, -3.2)]//firstStmt
    [TestCase(0.7213, -4)]
    [TestCase(-1, 0)]
    [TestCase(-1, -5)]



    [TestCase(0.6564, 0.5)]//secondStmt
    [TestCase(-1, 50)]
    [TestCase(0.9350, 0.6)]
    public void Stmt(double res, double x)
    {
        Assert.That(obj.fX(x), Is.EqualTo(res).Within(0.0001));
    }

    [TestCase(0.7213, -4)]
    [TestCase(-1.8408, -3.2)]
    [TestCase(-1, 0)]
    [TestCase(-1, -5)]

    public void firstStmt(double res, double x)
    {
        Assert.That(obj.firstStmt(x), Is.EqualTo(res).Within(0.0001));
    }

    [TestCase(0.6564, 0.5)]
    [TestCase(-1, 50)]
    [TestCase(-1, -4)]
    [TestCase(0.9350, 0.6)]
    public void secondStmt(double res, double x)
    {
        Assert.That(obj.secondStmt(x), Is.EqualTo(res).Within(0.0001));
    }


    [TestCase(0.995004, 0.1)]
    [TestCase(0.995004, -0.1)]
    [TestCase(-0.653644, 4)]
    [TestCase(-0.653644, -4)]
    [TestCase(-1, -5)]
    [TestCase(-1, 100)]
    public void Cos(double res, double x)
    {
        Assert.That(obj.Cos(x), Is.EqualTo(res).Within(0.0001));
    }

    [TestCase(0.0998334, 0.1)]
    [TestCase(-0.0998334, -0.1)]
    [TestCase(-0.756802, 4)]
    [TestCase(0.756802, -4)]
    [TestCase(-1, -6)]
    [TestCase(-1, 100)]
    public void Sin(double res, double x)
    {
        Assert.That(obj.Sin(x), Is.EqualTo(res).Within(0.0001));
    }

    [TestCase(-2.30259, 0.1)]
    [TestCase(0.641854, 1.9)]
    [TestCase(-1, 5)]
    [TestCase(-1, -3)]
    public void Log(double res, double x)
    {
        Assert.That(obj.Log(x), Is.EqualTo(res).Within(0.0001));
    }

    [TestCase(1, 1, 2)]
    [TestCase(1, 123, 0)]
    [TestCase(-1, 20, -2)]
    [TestCase(-100000, -10, 5)]
    public void Pow(double res, double x, int n)
    {
        Assert.That(obj.Pow(x, n), Is.EqualTo(res).Within(0.0001));
    }

    [TestCase(2432902008176640000, 20)]
    [TestCase(1, 0)]
    [TestCase(-1, -1)]
    [TestCase(-1, 21)]
    public void Factorial(double res, long n)
    {
        Assert.That(obj.Factorial(n), Is.EqualTo(res).Within(0.0001));
    }

    [TestCase(1, 1)]
    [TestCase(1, -1)]
    [TestCase(100.5, -100.5)]
    [TestCase(10000, 10000)]
    public void Abs(double res, double x)
    {
        Assert.That(obj.Abs(x), Is.EqualTo(res).Within(0.0001));
    }

    [TestCase(5, 25)]
    [TestCase(-1, -1)]
    [TestCase(3.240370, 10.5)]
    [TestCase(10, 100)]
    public void Sqrt(double res, double x)
    {
        Assert.That(obj.Sqrt(x), Is.EqualTo(res).Within(0.0001));
    }
}
