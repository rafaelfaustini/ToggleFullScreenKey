using System;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;
using ToggleFullScreenKey;

namespace ToggleFullscreenKey
{
    public class ModEntry : Mod
    {
        private ModConfig Config;

        public override void Entry(IModHelper helper)
        {
            this.Config = this.Helper.ReadConfig<ModConfig>();
            helper.Events.Input.ButtonPressed += this.OnButtonPressed;
        }
        private void OnButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            try
            {
                SButton botaoMenu = this.Config.getSButton();
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
