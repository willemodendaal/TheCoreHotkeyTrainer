using System;
using System.Collections.Generic;

namespace TheCoreHotkeyTrainer.Layouts.Righty.Medium
{
	internal class RandomRightyMedium : KayboardLayoutBase, IKeyboardLayout
	{
		public RandomRightyMedium()
		{
			ShortCode = "RRM";
			DisplayName = "Random Righty Medium";
			SupportedKeyCombinations = new List<KeyCombination>
			{
				new KeyCombination(ConsoleKey.J),
				new KeyCombination(ConsoleKey.I),
				new KeyCombination(ConsoleKey.O),
				new KeyCombination(ConsoleKey.P),

				new KeyCombination(ConsoleKey.J, ConsoleModifiers.Alt),
				new KeyCombination(ConsoleKey.I, ConsoleModifiers.Alt),
				new KeyCombination(ConsoleKey.O, ConsoleModifiers.Alt),
				new KeyCombination(ConsoleKey.P, ConsoleModifiers.Alt),

				new KeyCombination(ConsoleKey.J, ConsoleModifiers.Control),
				new KeyCombination(ConsoleKey.I, ConsoleModifiers.Control),
				new KeyCombination(ConsoleKey.O, ConsoleModifiers.Control),
				new KeyCombination(ConsoleKey.P, ConsoleModifiers.Control),

				new KeyCombination(ConsoleKey.J, ConsoleModifiers.Shift),
				new KeyCombination(ConsoleKey.I, ConsoleModifiers.Shift),
				new KeyCombination(ConsoleKey.O, ConsoleModifiers.Shift),
				new KeyCombination(ConsoleKey.P, ConsoleModifiers.Shift),

				new KeyCombination(ConsoleKey.J, ConsoleModifiers.Shift | ConsoleModifiers.Control),
				new KeyCombination(ConsoleKey.I, ConsoleModifiers.Shift | ConsoleModifiers.Control),
				new KeyCombination(ConsoleKey.O, ConsoleModifiers.Shift | ConsoleModifiers.Control),
				new KeyCombination(ConsoleKey.P, ConsoleModifiers.Shift | ConsoleModifiers.Control),

			};
		}
	}
}