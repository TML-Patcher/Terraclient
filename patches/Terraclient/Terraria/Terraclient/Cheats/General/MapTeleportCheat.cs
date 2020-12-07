﻿using Terraria.Localization;

namespace Terraria.Terraclient.Cheats.General
{
	public class MapTeleportCheat : ICheat
	{
		public bool isEnabled = true;

		public string Name() => Language.GetTextValue("Cheats.MapTeleportName");

		public string Description() => Language.GetTextValue("Cheats.MapTeleportDesc");

		public bool IsEnabled() => isEnabled;

		public void SwitchEnabled() => isEnabled = !isEnabled;
	}
}
