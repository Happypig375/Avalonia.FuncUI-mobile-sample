open AvaApp
open System
open Avalonia

// Initialization code. Don't use any Avalonia, third-party APIs or any
// SynchronizationContext-reliant code before AppMain is called: things aren't initialized
// yet and stuff might break.
[<STAThread; EntryPoint>]
let Main(args: string array) =
    AppBuilder.Configure<App>()
        .UsePlatformDetect()
        .LogToTrace(?level = None)
        .StartWithClassicDesktopLifetime(args)