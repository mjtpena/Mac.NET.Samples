using AppKit;
using CoreLocation;
using Foundation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HelloMacOS
{
    [Register("AppDelegate")]
    public class AppDelegate : NSApplicationDelegate
    {
        public AppDelegate()
        {
        }

        public override void WillFinishLaunching(NSNotification notification)
        {
            var manager = new CLLocationManager();
            manager.RequestAlwaysAuthorization();
        }

        public override void DidFinishLaunching(NSNotification notification)
        {
            CreateHostBuilder(null).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
        .ConfigureServices((hostContext, services) =>
        {
            services.AddHostedService<Worker>();
        });
    }
}
