using System;
using System.Collections.Generic;

namespace TheCoreHotkeyTrainer.Layouts.Righty.Medium
{
	internal class ZergRightyMedium : KayboardLayoutBase, IKeyboardLayout
	{
		public ZergRightyMedium()
		{
			ShortCode = "ZRM";
			DisplayName = "Zerg Righty Medium";
			SupportedKeyCombinations = new List<KeyCombination>
			{
				new KeyCombination(ConsoleKey.J),
			};
		}
	}
}
