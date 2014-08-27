using System;
using System.Collections.Generic;

namespace TheCoreHotkeyTrainer.Layouts.Righty.Medium
{
	internal class ProtossRightyMedium : KayboardLayoutBase, IKeyboardLayout
	{
		public ProtossRightyMedium()
		{
			ShortCode = "PRM";
			DisplayName = "Protoss Righty Medium";
			SupportedKeyCombinations = new List<KeyCombination>
			{
				new KeyCombination(ConsoleKey.J),
			};
		}
	}
}
