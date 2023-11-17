using FluentAssertions;

namespace Solutions.Test;

public class MultiplesOfThreeOrFivesTests
{
    [Fact]
    public void BruteForce_ShouldEqual()
    {
        EulerProblems.MultiplesOfThreeOrFive.BruteForce().Should().Be(233_168);
    }

    [Fact]
    public void DoublePass_ShouldEqual()
    {
        EulerProblems.MultiplesOfThreeOrFive.DoublePass().Should().Be(233_168);
    }
}