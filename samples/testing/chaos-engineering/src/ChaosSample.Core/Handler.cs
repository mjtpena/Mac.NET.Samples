namespace ChaosSample.Core;
public class Handler { public string Process() => "Chaos engineering ready"; }
public class ChaosMonkey {
    public bool InjectFault(string scenario) => scenario == "network-delay";
}