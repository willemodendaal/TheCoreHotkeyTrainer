using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCoreHotkeyTrainer.Layouts
{
	internal class RandomRightyMedium : IKeyboardLayout
	{
		public string ShortCode { get; private set; }
		public string DisplayName { get; private set; }
		public IList<KeyCombination> SupportedKeyCombinations { get; private set; }
		

		public RandomRightyMedium()
		{
			ShortCode = "RRM";
			DisplayName = "Random Righty Medium";
			SupportedKeyCombinations = new List<KeyCombination>
			{
				new KeyCombination('j'),
				new KeyCombination('i'),
				new KeyCombination('o'),
				new KeyCombination('p'),

				new KeyCombination('j', ConsoleModifiers.Alt),
				new KeyCombination('i', ConsoleModifiers.Alt),
				new KeyCombination('o', ConsoleModifiers.Alt),
				new KeyCombination('p', ConsoleModifiers.Alt),

				new KeyCombination('j', ConsoleModifiers.Control),
				new KeyCombination('i', ConsoleModifiers.Control),
				new KeyCombination('o', ConsoleModifiers.Control),
				new KeyCombination('p', ConsoleModifiers.Control),

				new KeyCombination('j', ConsoleModifiers.Shift),
				new KeyCombination('i', ConsoleModifiers.Shift),
				new KeyCombination('o', ConsoleModifiers.Shift),
				new KeyCombination('p', ConsoleModifiers.Shift),

				new KeyCombination('j', ConsoleModifiers.Shift | ConsoleModifiers.Control),
				new KeyCombination('i', ConsoleModifiers.Shift | ConsoleModifiers.Control),
				new KeyCombination('o', ConsoleModifiers.Shift | ConsoleModifiers.Control),
				new KeyCombination('p', ConsoleModifiers.Shift | ConsoleModifiers.Control),

			};
		}


		public KeyCombination GetRandomKeyCombination()
		{
			int randomIndex = new Random().Next(SupportedKeyCombinations.Count - 1);
			return SupportedKeyCombinations[randomIndex];
		}
	}
}