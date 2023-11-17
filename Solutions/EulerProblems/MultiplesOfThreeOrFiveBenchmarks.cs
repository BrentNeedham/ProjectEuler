using BenchmarkDotNet.Attributes;

namespace Solutions.EulerProblems;

[MemoryDiagnoser]
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class MultiplesOfThreeOrFiveBenchmarks
{
    [Benchmark]
    public void BruteForce()
    {
        MultiplesOfThreeOrFive.BruteForce();
    }

    [Benchmark]
    public void DoublePass()
    {
        MultiplesOfThreeOrFive.DoublePass();
    }
}
