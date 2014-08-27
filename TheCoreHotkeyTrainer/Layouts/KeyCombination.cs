using System;

namespace TheCoreHotkeyTrainer.Layouts
{
	internal class KeyCombination
	{
		public ConsoleKey Key { get; private set; }
		public ConsoleModifiers AltCtrlShiftKeysPressed { get; set; }

		public KeyCombination(ConsoleKey key, ConsoleModifiers altCtrlShiftKeysPressed = 0)
		{
			Key = key;
			AltCtrlShiftKeysPressed = altCtrlShiftKeysPressed;
		}

		public KeyCombination(ConsoleKeyInfo keyPressedInfo)
		{
			Key = keyPressedInfo.Key;
			AltCtrlShiftKeysPressed = keyPressedInfo.Modifiers;
		}

		public override string ToString()
		{
			if (AltCtrlShiftKeysPressed == 0)
				return Key.ToString().ToUpper();

			return AltCtrlShiftKeysPressed.ToString().Replace(", ", " + ")
				+ " + " + Key.ToString().ToUpper();
		}
	}
}