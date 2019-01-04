using System;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;
using Microsoft.Xna.Framework;

namespace RandomHairColorMod
{
    public class HairColorMod : Mod
    {
        /************ Public methods *********/
        /// <summary>The mod entry point, called after the mod is first loaded.</summary>
        /// <param name="helper">Provides simplified APIs for writing mods.</param>
        public override void Entry(IModHelper helper)
        {
            // event += method to call
            helper.Events.GameLoop.DayStarted += this.OnDayStarted;
        }

        /// <summary>The method called after a new day starts.</summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void OnDayStarted(object sender, DayStartedEventArgs e)
        {
            Game1.textColor = Color.Blue;
            Game1.textShadowColor = Color.BlueViolet;
        }
    }
}
