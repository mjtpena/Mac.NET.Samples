**The State of .NET on Mac OS** **<!--fit-->**

###### by Michael John Peña
---

# Agenda

:memo: Nomenclature and Definition of Terms

:vs: Different toolsets and IDE

:t-rex: Mono and .NET

:desktop_computer: Xamarin.Mac and Xamarin.Forms

:spider_web: .NET 5 (ASPNET Core and Worker Service)

:rocket: .NET 6, Mac Catalyst, and MAUI

---

# Mono

- Started by [Miguel de Icaza](https://twitter.com/migueldeicaza) (GNOME, Novell, Xamarin, Microsoft)

- Mono is an open source implementation of Microsoft's .NET Framework.

- Enabled .NET apps (before .NET Core) to run on MacOS, Linux, and mobile operating systems such as Android, iOS, and Tizen.

- The roots of what's now called Xamarin.

---

# Demo #1 : Mono and .NET
https://github.com/mjtpena/Mac.NET.Samples/tree/main/Mono

---

# Xamarin.Mac

- Started as MonoMac.

- Native bindings of Mac OS APIs exposed via C#

- Works with Cocoa library features: ".storyboard" / ".xib"

- Follows the same native principles: AppDelegate, Main, Entitlements, Plist

- Uses XCode to bundle the ".app"

---

# Xamarin.Forms

- Cross Platform UI Framework: MacOS, iOS, Android and Windows

- Create native components using XAML / C# / F#

- The Xamarin.Mac project references Xamarin.Forms project

- Can invoke platform specific methods

- Applies conventions like MVVM (Model-View-ViewModel)

---

# Demo #2: Xamarin.Mac and Xamarin.Forms
https://github.com/mjtpena/Mac.NET.Samples/tree/main/Xamarin

---

# .NET 5 (Core)

- General purpose framework to build apps targeting Windows, Linux, and MacOS

- **What works on Mac:**

  - ASPNET Family (Blazor, API, gRPC, React, Angular, Vue, etc)

  - Console apps & worker services

  - Machine Learning, IoT, Docker

- On MacOS, it doesn't interface with Cocoa or rich native libraries

- You can invoke some System variables and call command line such as Airport

---

# Demo #3: .NET 5 (Web and Worker Service)
https://github.com/mjtpena/Mac.NET.Samples/tree/main/DotNet5

---

# Mac Catalyst

- Shared SDK codes between Mac OS and iPad OS (not iOS)

- Unified components like pop-up buttons, tooltips, window's sidebar

- Unified GameKit, PassKit, MediaPlyer, Core Audio, Core Bluetooth, etc

- Requires XCode 13 on MacOS Big Sur / Monterey

---

# .NET 6 + MAUI (and beyond)

- More shared libraries across Xamarin/Mono and .NET Framework family

- Introduced the concept of `workload`

  - `dotnet workload install microsoft-macos-sdk-full`

  - `dotnet workload install microsoft-maccatalyst-sdk-full`

  - `dotnet workload install maui-maccatalyst`

- Xamarin.Mac => Microsoft-MacOS
- Xamarin.MaciOS + Mac Catalyst => **Microsoft-MacCatalst**
- Xamarin.Forms + UWP => **MAUI**

---

# Demo #4: .NET 6, Mac Catalyst, and MAUI
https://github.com/mjtpena/Mac.NET.Samples/tree/main/DotNet6

---

# Resources

[mjtpena/Mac.NET.Samples](https://github.com/mjtpena/Mac.NET.Samples)

[Mac Catalyst Overview - Apple Developer](https://developer.apple.com/mac-catalyst/)

[.NET Blog (microsoft.com)](https://devblogs.microsoft.com/dotnet/)

[dotnet/maui-samples](https://github.com/dotnet/maui-samples)

[Mono Project](https://www.mono-project.com/)

---

**Thank you for reading! :v:** **<!--fit-->**

###### michael@datachain.consulting

###### https://michaeljohnpena.com

###### [@mjtpena / Twitter](https://twitter.com/mjtpena)

###### [LinkedIn](https://www.linkedin.com/in/michaeljohnpena/)

---

[datachain website]: https://datachain.consulting
