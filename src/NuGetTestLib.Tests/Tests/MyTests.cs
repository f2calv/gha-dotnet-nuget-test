﻿using Xunit;
namespace CasCap.Tests;

public class MyTests
{
    [Fact]
    public void Test()
    {
        var obj = new MyClass();
        Assert.Equal(2, obj.ProduceValue());
    }
}