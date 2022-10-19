using Xunit;
using Src;

namespace Tests;

public class ResultTest
{
    [Fact]
    public void Test1()
    {
        var s = "SOSSPSSQSSOR";

        var expected = 3;

        var actual = Result.marsExploration(s);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        var s = "SOSSOT";

        var expected = 1;

        var actual = Result.marsExploration(s);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test3()
    {
        var s = "SOSOOSOSOSOSOSSOSOSOSOSOSOS";

        var expected = 12;

        var actual = Result.marsExploration(s);

        Assert.Equal(expected, actual);
    }
}