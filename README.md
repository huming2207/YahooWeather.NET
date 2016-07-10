YahooWeatherDotNet
===================


Introduction
-----------------
YahooWeatherDotNet is a Yahoo Weather API parsing library for .NET Platform.

This is a sub-project for [Project Apodidae](https://github.com/huming2207/ApodidaeClock), a smart alarm clock based on ESP8266 platform (or maybe Raspberry Pi / "Sunxi" Allwinner platforms, haven't decided yet. )

> **Note:**

> - Still work in progress


Currently supports:

 - Mono 4.x (Tested on Mac OS X 10.11.5 with Mono 4.4.1)
 - Microsoft native .NET toolchains (Haven't tested yet, but suppose to work fine.)


How to use
----------

For example, if you want to get the current temperature in Melbourne, Victoria, Australia, then:
```C#
var ywasync = new YahooWeatherControl(true);
var result = await ywasync.DoQuery("Melbourne", "Victoria");

Console.WriteLine("Current temperature in Melbourne: {0}", result.Result.Results.Channel.Item.Condition.Temperature);
```

It's simple. You just set your **city/district** and **your province/region/state**, then you will get the result you need.

BTW, you may need to have a look at [Yahoo Weather Developer Documentation](https://developer.yahoo.com/weather/).


Author
------

Jackson Ming Hu
@ RMIT Univeristy, Melbourne, Australia. 🇦🇺

Email: huming2207@gmail.com

PS: Sorry for my English, I'm a native Chinese. 🇨🇳 I need to improve it ASAP.


Licence
-------

LGPL
