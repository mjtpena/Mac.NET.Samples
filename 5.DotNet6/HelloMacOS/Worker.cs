using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AppKit;
using CoreWlan;
using Foundation;
using Microsoft.Extensions.Hosting;

namespace HelloMacOS
{
    public class Worker : BackgroundService
    {
        public Worker()
        {
        }
    
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var currentInterface = new CWInterface ("en0");
            
            NSError error;
            var scannedNetworks = currentInterface.ScanForNetworksWithName (null, out error);

            var networksForDataSource = scannedNetworks.ToList<CWNetwork>();

            foreach (var network in networksForDataSource)
            {
                var alert = new NSAlert()
                {
                    AlertStyle = NSAlertStyle.Informational,
                    InformativeText = @$"Microsoft.Extensions.Hosting running on MacOS using .NET 6. This is a native hardware library call. Network SSID: {(NSString)network.Ssid} BSSID: {(NSString)network.Bssid}, Signal Quality: {network.Rssi.ToString()} ",
                    MessageText = @$"Hello {Environment.UserName}",
                };
                alert.RunModal();
            }

            await Task.Delay(3000, stoppingToken);
        }
    }
}