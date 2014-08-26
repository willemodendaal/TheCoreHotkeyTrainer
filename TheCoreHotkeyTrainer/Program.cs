using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoreHotkeyTrainer.Layouts;

namespace TheCoreHotkeyTrainer
{
	internal class Program
	{
		//private static void Main()
		//{
		//	var pressed = Console.ReadKey(true);
		//	int keyCharNr = (int) pressed.KeyChar;
		//	char castChar = (char) (keyCharNr + 64);
		//	Console.WriteLine("Cast char:" + castChar );
		//	Console.ReadKey();
		//}


		private static void Main(string[] args)
		{
			OutputIntroText();

			Console.TreatControlCAsInput = true;
			ConsoleKeyInfo pressedKey;

			IKeyboardLayout keyboardLayout = GetKeyboardLayout();

			do
			{
				KeyCombination randomCombination = keyboardLayout.GetRandomKeyCombination();
				Out(randomCombination.ToString());

				pressedKey = Console.ReadKey(true);

				if (KeyPressMatches(pressedKey, randomCombination))
					Out("Correct!");
				else
					Out("Fail. You pressed " + GetKeyCombinationString(pressedKey));

			} while (pressedKey.Key != ConsoleKey.Escape);
		}

		private static string GetKeyCombinationString(ConsoleKeyInfo pressedKey)
		{
			if (pressedKey.Modifiers == 0)
				return pressedKey.Key.ToString();

			return pressedKey.Modifiers.ToString().Replace(", ", " + ")
				+ " + " + pressedKey.Key;
		}

		private static void OutputIntroText()
		{
			Out("TheCore HotKey Trainer");
			Out("----------------------");
			Out("This first version only supports the RRM layout.");
			Out("Press <escape> to exit.");
		}

		private static bool KeyPressMatches(ConsoleKeyInfo pressedKey, KeyCombination randomCombination)
		{
			return pressedKey.Key.ToString().ToUpper() == char.ToUpperInvariant(randomCombination.Key).ToString()
			       && pressedKey.Modifiers == randomCombination.AltCtrlShiftKeysPressed;
		}

		private static IKeyboardLayout GetKeyboardLayout()
		{
			return new RandomRightyMedium();
		}

		private static void Out(string msg)
		{
			Console.WriteLine(msg);
		}
	}
}