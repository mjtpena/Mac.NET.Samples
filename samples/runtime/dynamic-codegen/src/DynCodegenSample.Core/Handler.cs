namespace DynCodegenSample.Core;
public class Handler { public string Process() => "Dynamic codegen ready"; }
public class DynamicMethod {
    public static int ExecuteAddition(int a, int b) => a + b;
}