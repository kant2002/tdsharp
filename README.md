# TDLib

.NET bindings for TDLib (Telegram Database Library): https://github.com/tdlib/td
* Generated API bindings
* .NET Core and .NET Standard support

### Installation

Install via NuGet: ```TDLib```

[![NuGet](https://img.shields.io/nuget/v/TDLib.svg)](https://www.nuget.org/packages/TDLib/)

### Dependencies

You're recommended to use precompiled version of TDLib native artifacts from NuGet: ```TDLib.Native```

[![NuGet](https://img.shields.io/nuget/v/tdlib.native.svg)](https://www.nuget.org/packages/tdlib.native/)

Note that `tdlib.native` is not a dependency of `TDLib`, so you may choose to build the binaries yourself and provide them at the runtime.

To do that, [build TDLib](https://core.telegram.org/tdlib/docs/index.html#building) and put the compiled library into your project's output directory
* tdjson.dll (Windows) (optionally accompanied by other DLL files from the build directory if you want to bundle OpenSSL and ZLib dependencies as well)
* libtdjson.dylib (MacOS)
* libtdjson.so (Linux)

### Using json client

TdJsonClient is a wrapper around native JSON APIs. Use it to send/receive data as strings.

```csharp
using TdLib;

var json = ""; // json data
double timeout = 1.0; // 1 second

using (var jsonClient = new TdJsonClient())
{
    jsonClient.Send(json); // send request
    var result = jsonClient.Receive(timeout); // receive response
}
```

### Using strongly typed APIs

This library contains generated classes for objects and functions. JSON serialization and deserialization is handled automatically. Use TdClient to asynchronously execute functions.

```csharp
using TdLib;

using (var client = new TdClient())
{
    try
    {
        // asynchronously execute function
        TdApi.Ok ok = await client.ExecuteAsync(new TdApi.SetAuthenticationPhoneNumber
        {
            PhoneNumber = phoneNumber
        });

        // or use extension method
        ok = await client.SetAuthenticationPhoneNumberAsync(phoneNumber);

        // do something...
    }
    catch (ErrorException e)
    {
        TdApi.Error error = e.Error;

        // handle error...
    }
}
```

### Overriding native bindings

By default, TdSharp will try to detect the platform and use the corresponding bindings to native td library. In case you want to override it (e.g. for Xamarin), create a custom implementation of `ITdLibBindings` (which corresponds to native library interface used by TdSharp) and pass it to `TdClient` constructor.

### Documentation

- [Changelog][docs.changelog]
- [License (MIT)][docs.license]
- [Instructions for Maintainers][docs.maintainership]

[docs.changelog]: ./CHANGELOG.md
[docs.license]: ./LICENSE
[docs.maintainership]: ./MAINTAINERSHIP.md
