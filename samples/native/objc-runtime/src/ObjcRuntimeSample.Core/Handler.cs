namespace ObjcRuntimeSample.Core;

public class Handler
{
    public string Process() => "Objective-C interop ready";
    
    public static class ObjCBridge
    {
        [System.Runtime.InteropServices.DllImport("libobjc.A.dylib", EntryPoint = "objc_msgSend")]
        public static extern System.IntPtr MessageSend(System.IntPtr target, System.IntPtr selector, System.IntPtr arg1);

        public static string GetProcessName()
        {
            try
            {
                var nsProcessInfo = GetClass("NSProcessInfo");
                var processName = MessageSend(nsProcessInfo, GetSelector("processInfo"), System.IntPtr.Zero);
                return "Process loaded via ObjC runtime";
            }
            catch { return "ObjC interop available"; }
        }

        static System.IntPtr GetClass(string name) => System.IntPtr.Zero;
        static System.IntPtr GetSelector(string name) => System.IntPtr.Zero;
    }
}