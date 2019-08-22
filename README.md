# GetBroswerTimeZone
A simple library to get the broswer time zone and display clients local time.

## Install
[![NuGet Pre Release](https://img.shields.io/nuget/vpre/GetBroswerTimeZone.svg)](https://www.nuget.org/packages/GetBroswerTimeZone/)

## Useage
Include <script src="_content/GetBroswerTimeZone/TimeZone.js"></script> in your _Host.CsHtml file

```html 
<UTCToLocal Date="DateTime.UtcNow" Pattern="MMMM dd" /><br />
<UTCToLocal Date="DateTime.UtcNow" /><br />
<UTCToDateTime TimeZone="Eastern Standard Time" Date="DateTime.UtcNow" Pattern="MMMM dd" /><br />
<UTCToDateTime TimeZone="Eastern Standard Time" Date="DateTime.UtcNow" /><br />
```
