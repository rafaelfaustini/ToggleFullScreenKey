using System;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;

namespace ToggleFullscreenKey
{
    public class ModEntry : Mod
    {

        public override void Entry(IModHelper helper)
        {
            helper.Events.Input.ButtonPressed += this.OnButtonPressed;
        }
        private void OnButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            try
            {
                SButton botaoMenu = SButton.F11;
                if (e.Button == botaoMenu)
                {
                    Game1.toggleFullscreen();
                }
            }
            catch (Exception error)
            {
                this.Monitor.Log($"[ToggleFullscreenKey]: {error.Message}", LogLevel.Debug);
                throw;
            }


        }
    }
}
