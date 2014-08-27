using System;
using System.Collections.Generic;

namespace TheCoreHotkeyTrainer.Layouts.Righty.Medium
{
	internal class TerranRightyMedium : KayboardLayoutBase, IKeyboardLayout
	{
		public TerranRightyMedium()
		{
			ShortCode = "TRM";
			DisplayName = "Terran Righty Medium";
			SupportedKeyCombinations = new List<KeyCombination>
			{
				new KeyCombination(ConsoleKey.J),
			};
		}
	}
}
