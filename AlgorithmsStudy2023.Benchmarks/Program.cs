using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace AlgorithmsStudy2023.Benchmarks;

internal class Program
{
    private static void Main(string[] args)
    {
#if DEBUG
        BenchmarkRunner.Run<BinaryGapSolutionBenchmark>(
            new DebugBuildConfig().WithOption(ConfigOptions.DisableOptimizationsValidator, true));
#endif

#if !DEBUG
        BenchmarkRunner.Run<BinaryGapSolutionBenchmark>();
#endif
        Console.ReadKey();
    }
}