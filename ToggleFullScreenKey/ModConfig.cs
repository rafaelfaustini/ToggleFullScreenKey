using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StardewModdingAPI;

namespace ToggleFullScreenKey
{
    class ModConfig
    {
        public int key { get; set; } = 122;

        public SButton getSButton()
        {
            SButton button;
            try
            {
                button = (SButton)this.key;
                return button;
            }
            catch (Exception)
            {
                button = SButton.F11;
                return button;
                throw;
            }
        }

    }
}
