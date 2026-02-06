namespace ReflectionSample.Core;

public class Handler { public string Process() => "Reflection ready"; }

public class TypeInspector
{
    public string GetTypeName<T>(T obj) => typeof(T).Name;

    public string[] GetProperties<T>() 
        => typeof(T).GetProperties().Select(p => p.Name).ToArray();

    public int GetMethodCount<T>() 
        => typeof(T).GetMethods().Length;
}