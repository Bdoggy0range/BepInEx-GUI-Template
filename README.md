# BepInEx-GUI-Template
Very simple GUI for unity games with BepInEx

# Features

Simple GUI created with a RainbowLib

# RainbowLib Usage

RainbowLib.RainbowText("Rainbow Text Example", startX, currentY, 16);
RainbowLib.RainbowLabel(new Rect(startX, currentY, 250, 20), "Rainbow Label");
if (RainbowLib.RainbowButton(new Rect(startX, currentY, buttonWidth, buttonHeight), "Rainbow Quit"))
{
  Application.Quit();
}
currentY += buttonHeight + spacing;
