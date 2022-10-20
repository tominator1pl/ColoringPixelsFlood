# ColoringPixelsFlood
Program that automaticly colors a picture in Coloring Pixels Game
<br />Requires .NET Framework 4.6.1 or later

Use the new Auto-Detection. Alt + Numpad 6
<br />Be sure to set Lock Completed Pixels and Remove completed colors from palette in the game settings

You can also try Turbo mode (requires switching VSync Off)

1. Select a picture type in X, Y, num of colors and color to start with (usualy 1)
2. Scroll away so you can see the whole image
3. Use the Auto-detection Alt + Numpad 6
4. Continue with instruction on top of the window
5. Press Alt + Numpad 1
6. If you can see that the bot works too fast and it skips pixels turn on "Skip square check"


Alt + Numpad 1 - Start
<br />Alt + Numpad 2 - Pause
<br />Alt + Numpad 3 - Resume
<br />Alt + Numpad 4 - Skip a color
<br />Alt + Numpad 5 - Wizard
<br />Alt + Numpad 6 - Auto Image Detection

Make sure that Coloring pixels are in focus

## Wizard
This program features a Wizard to help you mark what pixels you want to color.
Thanks to this it should work on any resolution.

1. Press Alt + Numpad 5 to start
2. Move your mouse to top left corner of the picture to select first corner.
3. Move your mouse to bottom right corner of the picture to select second corner. You should see a helper rectangle on the right side of the window.
4. Adjust the X and Y amount of squares if needed.
5. Press Alt + Numpad 1 to start.

## Auto Detection
This program also features a Automatic Detection of an Image.

1. Scroll away so you can see the whole image
2. Use the Auto-detection Alt + Numpad 6
3. Continue with instruction on top of the window
4. Press Alt + Numpad 1
5. If you can see that the bot works too fast and it skips pixels turn on "Skip square check"

With enough zoom out you can sometimes see that the bot skips entires lines of pixels. That happens because of floating point values are converted to integer and some data is lost. In tis case some lines will be 2 on screen pixels and some 1 on screen pixel wide. With te conversion it can sometimes skip the 1 pixel wide lines. To prevent it zoom out enough so ypu can see solid black and white image without any noise (see Picture below), this meant that every line is now 1 pixel wide and the problem shouldn't happen.
![Solid black and white picture](3rd.PNG "3rd Birthday")
