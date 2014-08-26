using System.Collections.Generic;

namespace TheCoreHotkeyTrainer.Layouts
{
	internal interface IKeyboardLayout
	{
		string ShortCode { get; }
		string DisplayName { get; }
		IList<KeyCombination> SupportedKeyCombinations { get; }

		KeyCombination GetRandomKeyCombination();
	}
}
