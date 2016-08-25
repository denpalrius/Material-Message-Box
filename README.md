# Material Message Box

A WPF Message Box implementing material design

[Download from Nuget](https://www.nuget.org/packages/MaterialMessageBox/)

## Usage
> Creating a simple message box

```c#
MaterialMessageBox.Show("Your cool message here", "The awesome message title");
```
> Showing an error message

```c#            
MaterialMessageBox.ShowError(@"This is an error message");
```

> Capturing Message Box Results

```c#    
var result = MaterialMessageBox.ShowWithCancel($"This is a simple message with a cancel button. You can listen to the return value", "Message Box Title");
```

> Capturing Message Box Results

```c#    
var msg = new CustomMaterialMessageBox
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
var results = msg.Result;
```


## Contributing to this project
If you've improved Material Message Box and think that other people would enjoy it, submit a pull request. Anyone and everyone is welcome to contribute.

* You could always contact me through Email for any feature or issue :)

* You need [Visual Studio 2015 Community/Enterprise Edition](<https://www.visualstudio.com/>) to build the solution.

## Toolkits used
I have implemented these awesome toolkits while creating this control. Hands up to these guys who have made the most beautiful controls for WPF. They have crossed the oceans on foot!

- [mahApps.Metro](https://github.com/MahApps/MahApps.Metro) A toolkit for creating Metro/Modern UI styled WPF apps
- [MaterialDesignInXamlToolkit](https://github.com/ButchersBoy/MaterialDesignInXamlToolkit) Google Material Design in XAML & WPF, for C# & VB.Net

## Main Features
The message box has the following custom features:
 1. Material Theme design
 2. Custom styles for border window, message foreground and background, title foreground and background, border, etc
 3. Button to copy message box details to clipboard
 4. Scrollable message box content
 5. Message content is .NET UIElement which can host any content


----------


## Licence
The MIT License (MIT)

Copyright (c) Microsoft Corporation

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
