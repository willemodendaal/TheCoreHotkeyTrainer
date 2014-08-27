using System;
using System.Collections.Generic;

namespace TheCoreHotkeyTrainer.Layouts
{
	internal class KayboardLayoutBase
	{
		public string ShortCode { get; protected set; }
		public string DisplayName { get; protected set; }
		public IList<KeyCombination> SupportedKeyCombinations { get; protected set; }

		public KeyCombination GetRandomKeyCombination()
		{
			int randomIndex = new Random().Next(SupportedKeyCombinations.Count - 1);
			return SupportedKeyCombinations[randomIndex];
		}
	}
}