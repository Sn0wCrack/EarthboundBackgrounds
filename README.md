# Earthbound Backgrounds
A program to creature earthbound battle backgrounds out of any image

## Download

[Downloads Here](https://github.com/Sn0wCrack/EarthboundBackgrounds/releases)

## What is this?
This is a simple (not really) program written in C# to manipulate images into Earthbound Style battlebackgrounds.

I got the idea after seeing an update from the Mother 4 Fangame Project's Team featuring the equation to creature Earthbound style backgrounds, and started this, gave up, and recently started working on it again.

## How does this work?

There's a lot of math involved, well not a lot, one equation, but that's still a lot!

Earthbound's Background's are quite mesmerising, and in fact are quite the feat to have pulled off on an SNES. The basic way they work is that the individual pixels are maniuplated based on an equation:

```Offset (y, t) = A sin ( F * y + S * t )```

A, F and S are constants, that yes, aren't really constant.

- A meaning Amplitude.

- F meaning Frequency.

- S meaning Scale.

All of that's pretty straight forward if you understand how a basic sine wave works and how it can be manipulated, however, Earthbound has multiple ways of manipulating it's backgrounds, three to be exact.

In all of these examples the new X position increases by 1 every time it loops through the row of pixels, making sure to at least shift things some what.

- Type 0:
  - Type 0 is the default style, it apples a basic sine wave to the image, nothing else happens to it.
  - Basically this means the output of the offset fucntion is made the new X position of the current pixel.

- Type 1:
  - Type 1 checks if the current y pixel is a multiple of 2, and if is, sets it to the offset, it it isn't it sets it to the inverse of the offset.
  
- Type 2:
  - Type 2 is the most interesting, this actually sets the Y position rather than the X, setting it to ```y * C + offset```
  - C in this case is the compression constant, y is the current y pixel, and offset is the computed offset for this pixel.
  - I don't truely even understand 100% what actually happens here.
  
  
In multilayer mode, the secondary layer is overlayed with parts of the first layer, making them seem as if they're interlocking. Technically, the game is always in "multilayer mode" however, a blank background can be used in place of one of the layers.

## Warnings
This program can use a lot of memory, like a lot, so I reccomend building for 64-bit if you want to do this with larger images.

I mainly reccomend using this program with 256x256 images with 8bpp, as that's what Earthbound was designed with and only what this program can handle.

When using multiple layers, the layer images **HAVE** to be the same size, no exceptions.

Remember, RAM usage is porpotionate to the size of the image you put in, don't expect to have low RAM usage, this manipulates images on a pixel by pixel basis, and has raw image data in memory.

There are crashes, I'm not 100% what all of them are, but the one you'll see the most will always be the Out Of Memory Exception, so please build for 64-bit.

This isn't perfect, so expect some errors and GUI blunders.

## Thanks

Thanks to [gjtorkian](https://github.com/gjtorikian) for the [Earthbound Battle Backgrounds in JS](https://github.com/gjtorikian/Earthbound-Battle-Backgrounds-JS) program.
Mr. Accidental of the Starman.net forums for his original look into the way Backgrounds are manipulated in Earthbound.
