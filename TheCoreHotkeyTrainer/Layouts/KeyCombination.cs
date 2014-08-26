using System;

namespace TheCoreHotkeyTrainer.Layouts
{
	internal class KeyCombination
	{
		public char Key { get; private set; }
		public ConsoleModifiers AltCtrlShiftKeysPressed { get; set; }

		public KeyCombination(char key, ConsoleModifiers altCtrlShiftKeysPressed = 0)
		{
			Key = key;
			AltCtrlShiftKeysPressed = altCtrlShiftKeysPressed;
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