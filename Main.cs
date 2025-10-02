using System;
using BepInEx;
using BepInEx.Logging;
using UnityEngine;

namespace BdoggyGUI
{
    [BepInPlugin("template.bdoggy.gui", "Bdoggy's GUI Template", "1.0.0")]
    public class GUIClass : BaseUnityPlugin
    {
        private Rect windowRect = new Rect(300, 300, 300, 400);
        private bool showWindow = true;
        private int windowId;

        private void Awake()
        {
            windowId = GetHashCode();
            Logger.LogInfo("Bdoggy's GUI Template has successfully loaded!");
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F1)) showWindow = !showWindow;
        }

        private void OnGUI()
        {
            if (!showWindow) return;
            windowRect = GUI.Window(windowId, windowRect, DrawWindow, "GUI Demo");
        }

        private void DrawWindow(int id)
        {
            int buttonWidth = 200;
            int buttonHeight = 30;
            int startX = 10;
            int startY = 30;
            int spacing = 10;

            int currentY = startY;

            // ---------- Normal vs Rainbow Label ----------
            GUI.Label(new Rect(startX, currentY, 250, 20), "Normal Label");
            currentY += 25;
            RainbowLib.RainbowLabel(new Rect(startX, currentY, 250, 20), "Rainbow Label");
            currentY += 40;

            // ---------- Normal vs Rainbow Text ----------
            GUI.Label(new Rect(startX, currentY, 250, 20), "Normal Text Example");
            currentY += 25;
            RainbowLib.RainbowText("Rainbow Text Example", startX, currentY, 16);
            currentY += 40;

            // ---------- Normal vs Rainbow Button ----------
            if (GUI.Button(new Rect(startX, currentY, buttonWidth, buttonHeight), "Normal Quit"))
            {
                Application.Quit();
            }
            currentY += buttonHeight + spacing;

            if (RainbowLib.RainbowButton(new Rect(startX, currentY, buttonWidth, buttonHeight), "Rainbow Quit"))
            {
                Application.Quit();
            }
            currentY += buttonHeight + spacing;

            GUI.DragWindow();
        }
    }
}