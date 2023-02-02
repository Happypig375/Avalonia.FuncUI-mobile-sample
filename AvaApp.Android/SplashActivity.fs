namespace AvaApp.Android
open Android.App
open Android.Content
open Avalonia.Android
type Application = Android.App.Application

[<Activity(Theme = "@style/MyTheme.Splash", MainLauncher = true, NoHistory = true)>]
type SplashActivity() =
    inherit AvaloniaSplashActivity<AvaApp.App>()
    override this.CustomizeAppBuilder builder =
        base.CustomizeAppBuilder builder
    override this.OnResume() =
        base.OnResume()
        this.StartActivity(new Intent(Application.Context, typeof<MainActivity>))