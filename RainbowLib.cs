using UnityEngine;

namespace BdoggyGUI
{
    public static class RainbowLib
    {
        // Rainbow Text
        public static void RainbowText(string text, float x, float y, int fontSize = 14)
        {
            GUIStyle style = new GUIStyle(GUI.skin.label);
            style.fontSize = fontSize;

            float hue = Mathf.Repeat(Time.time * 0.2f, 1f); // smooth rainbow cycle
            style.normal.textColor = Color.HSVToRGB(hue, 1f, 1f);

            GUI.Label(new Rect(x, y, 300, fontSize + 10), text, style);
        }

        // Rainbow Label
        public static void RainbowLabel(Rect rect, string text, int fontSize = 14)
        {
            GUIStyle style = new GUIStyle(GUI.skin.label);
            style.fontSize = fontSize;

            float hue = Mathf.Repeat(Time.time * 0.2f, 1f);
            style.normal.textColor = Color.HSVToRGB(hue, 1f, 1f);

            GUI.Label(rect, text, style);
        }

        // Solid Rainbow Button
        public static bool RainbowButton(Rect rect, string text, int fontSize = 14)
        {
            GUIStyle style = new GUIStyle(GUI.skin.button);
            style.fontSize = fontSize;

            float hue = Mathf.Repeat(Time.time * 0.2f, 1f);
            style.normal.textColor = Color.HSVToRGB(hue, 1f, 1f);

            return GUI.Button(rect, text, style);
        }
    }
}