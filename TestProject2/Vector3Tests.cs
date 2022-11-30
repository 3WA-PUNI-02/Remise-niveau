using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

public class MyVector3Tests
{
    [Test]
    public void MyVector3IsAStruct()
    {
        Assert.IsTrue(typeof(MyVector3).IsClass == false);
    }

    [Test]
    public void MyVector3Constructor()
    {
        MyVector3 v = new MyVector3(1, 2, 3);
        Assert.AreEqual(1, v.X);
        Assert.AreEqual(2, v.Y);
        Assert.AreEqual(3, v.Z);
    }

    [Test]
    public void MyVector3ConstructorWithNegativ()
    {
        MyVector3 v = new MyVector3(-1, -2, -3);
        Assert.AreEqual(-1, v.X);
        Assert.AreEqual(-2, v.Y);
        Assert.AreEqual(-3, v.Z);
    }

    [Test]
    public void MyVector3TestSqrtMagnitude()
    {
        MyVector3 v = new MyVector3(3, 1, 2);
        Assert.AreEqual(3 * 3 + 1 * 1 + 2 * 2, v.SqrtMagnitude);
    }
    [Test]
    public void MyVector3TestMagnitude()
    {
        MyVector3 v = new MyVector3(3, 1, 2);
        Assert.AreEqual(Mathf.Sqrt(3 * 3 + 1 * 1 + 2 * 2), v.Magnitude);
    }

    [Test]
    public void MyVector3TestMagnitudeWithNegativ()
    {
        MyVector3 v = new MyVector3(2, 10, -2);
        Assert.AreEqual(Mathf.Sqrt(-2 * -2 + 10 * 10 + 2 * 2), v.Magnitude);
    }

    [Test]
    public void CreateMyVector3ThenChangeX()
    {
        MyVector3 v = new MyVector3(2, 10, -2);
        Assert.AreEqual(2, v.X);
        Assert.AreEqual(10, v.Y);
        Assert.AreEqual(-2, v.Z);

        v.X = 12;
        Assert.AreEqual(12, v.X);
        Assert.AreEqual(10, v.Y);
        Assert.AreEqual(-2, v.Z);
    }

    [Test]
    public void CreateMyVector3ThenChangeZ()
    {
        MyVector3 v = new MyVector3(2, 10, -2);
        Assert.AreEqual(2, v.X);
        Assert.AreEqual(10, v.Y);
        Assert.AreEqual(-2, v.Z);

        v.Y = 12;
        Assert.AreEqual(2, v.X);
        Assert.AreEqual(12, v.Y);
        Assert.AreEqual(-2, v.Z);
    }

    [Test]
    public void CreateMyVector3ThenChangeY()
    {
        MyVector3 v = new MyVector3(2, 10, -2);
        Assert.AreEqual(2, v.X);
        Assert.AreEqual(10, v.Y);
        Assert.AreEqual(-2, v.Z);

        v.Z = 12;
        Assert.AreEqual(2, v.X);
        Assert.AreEqual(10, v.Y);
        Assert.AreEqual(12, v.Z);
    }

    [Test]
    public void NormalizeWorks()
    {
        MyVector3 v = new MyVector3(2, 10, -2);
        Vector3 unityVector = new Vector3(2, 10, -2).normalized;

        v.Normalize();

        Assert.AreEqual(unityVector.x, v.X);
        Assert.AreEqual(unityVector.y, v.Y);
        Assert.AreEqual(unityVector.z, v.Z);
    }

    [Test]
    public void AddVector3()
    {
        MyVector3 v1 = new MyVector3(1, 2, 3);
        MyVector3 v2 = new MyVector3(3, 2, -12);

        var result = v1 + v2;
        Assert.AreEqual(4, result.X);
        Assert.AreEqual(4, result.Y);
        Assert.AreEqual(-9, result.Z);
    }

    [Test]
    public void MultiplyVector3ByFloat()
    {
        MyVector3 v1 = new MyVector3(1, 2, 3);
        var result = v1 * 2;

        Assert.AreEqual(2, result.X);
        Assert.AreEqual(4, result.Y);
        Assert.AreEqual(6, result.Z);
    }
}
;