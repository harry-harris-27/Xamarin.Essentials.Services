# Xamarin.Essentials.Services

[![NuGet Package](https://img.shields.io/nuget/v/Xamarin.Essentials.Services.svg?logo=nuget&logoColor=white&&style=for-the-badge&colorB=blue)](https://www.nuget.org/packages/Xamarin.Essentials.Services)

Xamarin.Essentials.Services offers a service-orientated approach to consuming the [Xamarin.Essentials](https://github.com/xamarin/Essentials) cross-platform APIs. This approach provides developers with the facilities for:
- Customization of Xamarin.Essentials features
- Dependency injection
- Mocking of Xamarin.Essentials feature for easier testing

## Installation

Xamarin.Essentials.Services is available via NuGet.

## Examples

### Customization
Customize existing Xamarin.Essentials features, e.g. log the clipboard text to the console everytime the clipboard is updated.
```C#
class MyClipboardService : ClipboardService
{
    public override Task SetTextAsync(string text)
    {
        System.Diagnostics.Debug.WriteLine(text);
        return base.SetTextAsync(text);
    }
}

// ...

IClipboardService clipboardService = new MyClipboardService();
await clipboardService.SetTextAsync("Hello World");
```

### Feature Mocking
Mock Xamarin.Essentials by mocking Xamarin.Essentials.Services interfaces to easily setup scenarios that would otherwise be difficult to simulate:
```C#
[TestMethod]
[ExpectedException(typeof(Exception), true]
public void Test_ThrowsExceptionIfNetworkUnavailable()
{
    var connectivityServiceMock = new Mock<IConnectivityService>();
    var myClass = new MyClass(connectivityServiceMock.Object);
    
    connectivityServiceMock.Setup(m => m.NetworkAccess).Returns(NetworkAccess.None);
    myClass.DoStuffRequiringNetworkAccess();
}
```

## Contributing

Clone the this repository: git clone `git clone https://github.com/harry-harris-27/Xamarin.Essentials.Services`

Pull requests are welcome. For major changes, please open an issue first to discuss what changes you would like to make.

Please make sure to update tests as appropriate.

## License
Please see the [License](LICENSE).
