# WebAPI2 Owin

Example project using [MSBuild.SDK.SystemWeb](https://github.com/CZEMacLeod/MSBuild.SDK.SystemWeb) to show WebAPI2 with Owin.

This is based on an Empty template from the SDK.

The Values controller was added from an example ASP.Net4 project.

Owin was added using with it set to host on SystemWeb - `Microsoft.Owin.Host.SystemWeb`

WebAPI2 was added to host in Owin - `Microsoft.AspNet.WebApi.Owin`.

Newtonsoft.Json was directly added to the project to ensure the newest version.

The latest release version of `Microsoft.Net.Compilers.Toolset` was selected by adding the 
```xml
<MicrosoftNetCompilersToolset_Version>4.2.0</MicrosoftNetCompilersToolset_Version>
```
line to the project file.

The web.config was set to automatically add binding redirects (required for `Microsoft.Owin` and `Newtonsoft.Json`) by adding the
```xml
    <GeneratedBindingRedirectsAction>Overwrite</GeneratedBindingRedirectsAction>
```
line to the project file.

The values controller was tweaked to show the identity of the accessing user using Owin Authentication.

The `launchSettings.json` file was tweaked to:
- Run in 64bit mode
- Launch the api/values url to hit the controller's get method.
- Enable windows authentication to use the logged in user to show in the values controller.

