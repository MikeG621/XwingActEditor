X-wing series ACT Editor
===============================================================================
Author: Michael Gaisser (mjgaisser@gmail.com)
Version 1.0.01
Date: 10.10.2009
===============================================================================

This editor reads and writes the ACT backdrop files used in TIE95 and XvT/BoP.

===================
VERSION HISTORY

v1.0.2 - 12 Aug 2015
 - Released under MPL 2.0
 
v1.0 - 10 Oct 2009
 - Release

===================
IMAGE GUIDELINES

Images must be 256x256 pixels or smaller, *255* colors or less. The program
will remove unused colors from the image palette. It's best if the image is 16
or 256 color format so as to retain the intended colors. RGB bitmaps will be
converted to 256 colors as best as possible.

===================
INSTRUCTIONS

- Open the ACT you wish to view or edit using the folder icon. The full path
will be displayed next to it. You may also type the full path directly into the
text box.
- The icons to the right of the text box are 'Save' and 'SaveAs'.
- The "Colors..." button at the bottom will take you to the Palette editor. The
number of colors can only be changed by importing a new picture. The first
color is Transparent and (255,0,255) by default, changing it will save the
displayed color for other image's use.
- The red border (only viewable for multi-frame images) is displayed to show
the overall image size in relation to the frame's size and position.
- The Center mark is displayed around the pixel used to position the image
in-game.
- Use the "Import..." button to load a bitmap. "<- Copy" will transfer that
bitmap to the opened ACT. If no ACT is open, a new one will be created.
- "Auto Center" when checked will center the imported bitmap around the ACT's
Center value.

As always, backup your original files first.

===============================================================================
Copyright (C) 2009 Michael Gaisser
This program and related files are licensed under the Mozilla Public License.
See License.txt for the full text. If for some reason the license was not
distributed with this program, you can obtain the full text of the license at
http://mozilla.org/MPL/2.0/.

"Star Wars" and related items are trademarks of LucasFilm Ltd and
LucasArts Entertainment Co.

This software is provided "as is" without warranty of any kind; including that
the software is free of defects, merchantable, fit for a particular purpose or
non-infringing. See the full license text for more details.