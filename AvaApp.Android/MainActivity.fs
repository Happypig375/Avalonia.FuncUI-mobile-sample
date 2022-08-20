namespace AvaApp.Android
open Android.App
open Android.Content.PM
open Avalonia.Android
open Avalonia

[<Activity(Label = "AvaApp.Android", Theme = "@style/MyTheme.NoActionBar", Icon = "@drawable/icon", LaunchMode = LaunchMode.SingleInstance, ConfigurationChanges = (ConfigChanges.Orientation ||| ConfigChanges.ScreenSize))>]
type MainActivity() =
    inherit AvaloniaActivity<AvaApp.App>()
    override this.CustomizeAppBuilder builder =
        base.CustomizeAppBuilder builder