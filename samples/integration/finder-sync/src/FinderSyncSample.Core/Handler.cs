namespace FinderSyncSample.Core;
public class Handler { public string Process() => "Finder sync ready"; }
public class FinderSync {
    public bool SyncEnabled { get; set; }
}