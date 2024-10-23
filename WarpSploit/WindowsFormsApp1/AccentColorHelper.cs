using System;
using System.Runtime.InteropServices;
using System.Drawing;

public class AccentColorHelper
{
    [DllImport("dwmapi.dll", EntryPoint = "DwmGetColorizationColor")]
    public static extern void DwmGetColorizationColor(out uint color, out bool opaque);

    public static Color GetAccentColor()
    {
        uint color;
        bool opaque;
        DwmGetColorizationColor(out color, out opaque);

        // Extract the RGB values from the color
        byte red = (byte)((color >> 16) & 0xFF);
        byte green = (byte)((color >> 8) & 0xFF);
        byte blue = (byte)(color & 0xFF);

        return Color.FromArgb(red, green, blue);
    }
}
