using BenchmarkDotNet.Attributes;

namespace AlgorithmsStudy2023.Benchmarks;

[MemoryDiagnoser]
[RankColumn]
public class BinaryGapSolutionBenchmark
{
    [Benchmark]
    public void PerformBenchmarkBinaryGapSolutionA() => BinaryGapSolution.Solution(987123);
    
    [Benchmark]
    public void PerformBenchmarkBinaryGapSolutionB() => BinaryGapSolution.Solution(1);
}
