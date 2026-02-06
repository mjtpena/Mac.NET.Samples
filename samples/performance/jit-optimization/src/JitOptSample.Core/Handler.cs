namespace JitOptSample.Core;
public class Handler { public string Process() => "JIT optimization ready"; }
public class JitBenchmark {
    public long TimeExecution(Action action, int iterations = 1000) {
        var sw = System.Diagnostics.Stopwatch.StartNew();
        for (int i = 0; i < iterations; i++) action();
        sw.Stop();
        return sw.ElapsedMilliseconds;
    }
}