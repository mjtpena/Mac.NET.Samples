using System.Runtime.InteropServices;
using ObjcRuntimeSample.Core;

var processName = ObjcRuntime.GetProcessName();
var osVersion = ObjcRuntime.GetOperatingSystemVersion();

Console.WriteLine(MessageFormatter.Format(processName, osVersion));

public static class ObjcRuntime
{
    private const string ObjcLib = "/usr/lib/libobjc.A.dylib";

    [DllImport(ObjcLib)]
    private static extern IntPtr objc_getClass(string name);

    [DllImport(ObjcLib)]
    private static extern IntPtr sel_registerName(string name);

    [DllImport(ObjcLib)]
    private static extern IntPtr objc_msgSend(IntPtr receiver, IntPtr selector);

    [DllImport(ObjcLib)]
    private static extern IntPtr objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr arg1);

    public static string GetProcessName()
    {
        var nsProcessInfo = objc_getClass("NSProcessInfo");
        var processInfoSel = sel_registerName("processInfo");
        var processInfo = objc_msgSend(nsProcessInfo, processInfoSel);
        var processNameSel = sel_registerName("processName");
        var nsString = objc_msgSend(processInfo, processNameSel);
        return NsStringToString(nsString);
    }

    public static string GetOperatingSystemVersion()
    {
        var nsProcessInfo = objc_getClass("NSProcessInfo");
        var processInfoSel = sel_registerName("processInfo");
        var processInfo = objc_msgSend(nsProcessInfo, processInfoSel);
        var versionStringSel = sel_registerName("operatingSystemVersionString");
        var nsString = objc_msgSend(processInfo, versionStringSel);
        return NsStringToString(nsString);
    }

    private static string NsStringToString(IntPtr nsString)
    {
        if (nsString == IntPtr.Zero)
        {
            return string.Empty;
        }

        var utf8Sel = sel_registerName("UTF8String");
        var utf8Ptr = objc_msgSend(nsString, utf8Sel);
        return Marshal.PtrToStringUTF8(utf8Ptr) ?? string.Empty;
    }
}
