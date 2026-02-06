namespace BenchmarkingSample.Core;
public class Handler { public string Process() => "Benchmarking ready"; }
public class BenchmarkResult { public string Name { get; set; } = ""; public long ElapsedMs { get; set; } }
public class SimpleBenchmark {
    public BenchmarkResult Run(string name, Action action) {
        var sw = System.Diagnostics.Stopwatch.StartNew();
        action();
        sw.Stop();
        return new() { Name = name, ElapsedMs = sw.ElapsedMilliseconds };
    }
}