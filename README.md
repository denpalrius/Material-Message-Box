# WPF Material Message Box

A WPF Message Box implementing material design

[![Release](https://img.shields.io/github/release/denpalrius/Material-Message-Box.svg)](https://github.com/denpalrius/Material-Message-Box/releases/latest)

:arrow_forward: [Download from Nuget](https://www.nuget.org/packages/MaterialMessageBox/)

:arrow_forward: Install from Package manager Console
> Install-Package MaterialMessageBox



## :sparkle: Main Features
The message box has the following custom features:

:white_check_mark: Material Theme design

:white_check_mark: Custom styles for border window, message foreground and background, title foreground and background, border, etc

:white_check_mark: Button to copy message box details to clipboard

:white_check_mark: Scrollable message box content

:white_check_mark: Message content is .NET UIElement which can host any content



## :sparkle: Usage

> Creating a simple message box

```c#
MaterialMessageBox.Show("Your cool message here", "The awesome message title");
```
![Simple Message](./MaterialMessageBoxDemo/Screenshots/Simple-Message-Box.png?raw=true "Creating a simple message box")

> Show a message box with RTL support

```c#
MaterialMessageBox.Show("Your cool message here", "The awesome message title", true);
```
![message box with RTL support](./MaterialMessageBoxDemo/Screenshots/Rtl-Message-Box.png?raw=true "Creating a message box with RTL support")

> Showing an error message

```c#            
MaterialMessageBox.ShowError(@"This is an error message");
```
![Error Message](https://raw.github.com/denpalrius/Material-Message-Box/master/MaterialMessageBoxDemo/Screenshots/Error-Message-Box.png)

> Showing an error message

```c#            
MaterialMessageBox.ShowError(@"This is an error message");
```
![Error Message](https://raw.github.com/denpalrius/Material-Message-Box/master/MaterialMessageBoxDemo/Screenshots/Error-Message-Box.png)

> Capturing Message Box Results

```c#    
var result = MaterialMessageBox.ShowWithCancel($"This is a simple message with a cancel button. You can listen to the return value", "Message Box Title");
```
![Capturing Message Box Results](https://raw.github.com/denpalrius/Material-Message-Box/master/MaterialMessageBoxDemo/Screenshots/Message-Box-With-Cancel-Button.png)


> Styling a message box

``` c#
CustomMaterialMessageBox msg = new CustomMaterialMessageBox
{
    TxtMessage = { Text = "Do you like white wine?", Foreground = Brushes.White },
    TxtTitle = { Text = "This is too cool", Foreground = Brushes.White },
    BtnOk = { Content = "Yes" },
    BtnCancel = { Content = "Noooo" },
    MainContentControl = { Background = Brushes.MediumVioletRed },
    TitleBackgroundPanel = { Background = Brushes.BlueViolet },

    BorderBrush = Brushes.BlueViolet
};

msg.Show();
MessageBoxResult results = msg.Result;
```
![Capturing Message Box Results](https://raw.github.com/denpalrius/Material-Message-Box/master/MaterialMessageBoxDemo/Screenshots/Styled-Message-Box.png)


## :sparkle: Contributing to this project
If you've improved Material Message Box and think that other people would enjoy it, submit a pull request. Anyone and everyone is welcome to contribute.

* You could always contact me through Email for any feature or issue. :star:

* You need [Visual Studio 2015 Community/Enterprise Edition](<https://www.visualstudio.com/>) (upwards) to build and test the solution.


## :sparkle: Toolkits used
This library is built on top of the following toolkits:
- [Material Design In XAML Toolkit](https://github.com/ButchersBoy/MaterialDesignInXamlToolkit) - Comprehensive and easy to use Material Design theme and control library for the Windows desktop.
- [Material Design Colors](https://github.com/MahApps/MahApps.Metro) - ResourceDictionary instances containing standard Google Material Design swatches, for inclusion in a XAML application.

----------

## :sparkle: Licence
The MIT License (MIT)

Copyright (c) 2021, Bespoke Fusion

Permission is hereby granted, free of charge, to any person obtaining a copy
 of this software and associated documentation files (the "Software"), to deal
 in the Software without restriction, including without limitation the rights
 to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 copies of the Software, and to permit persons to whom the Software is
 furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
 all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 THE SOFTWARE.



:heart:
