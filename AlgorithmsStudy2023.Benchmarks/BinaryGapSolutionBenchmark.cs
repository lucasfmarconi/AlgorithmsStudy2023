using BenchmarkDotNet.Attributes;

namespace AlgorithmsStudy2023.Benchmarks;

[MemoryDiagnoser]
[RankColumn]
public class BinaryGapSolutionBenchmark
{
    [Benchmark]
    public void PerformBenchmarkBinaryGapSolutionA() => BinaryGap.Solution(987123);
    
    [Benchmark]
    public void PerformBenchmarkBinaryGapSolutionB() => BinaryGap.Solution(1);
}
