open System.Runtime.Versioning
open Avalonia
open Avalonia.Browser

open AvaApp

module Program =
    [<assembly: SupportedOSPlatform("browser")>]
    do ()

    [<CompiledName "BuildAvaloniaApp">] 
    let buildAvaloniaApp () = 
        AppBuilder
            .Configure<App>()

    [<EntryPoint>]
    let main argv =
        buildAvaloniaApp()
            .StartBrowserAppAsync("out")
        |> ignore
        0