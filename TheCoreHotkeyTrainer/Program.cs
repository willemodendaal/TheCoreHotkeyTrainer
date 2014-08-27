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

		private static void Main(string[] args)
		{
			OutputIntroText();

			Console.TreatControlCAsInput = true;
			ConsoleKeyInfo pressedKey;

			IKeyboardLayout keyboardLayout = GetKeyboardLayout();

			do
			{
				KeyCombination randomCombination = keyboardLayout.GetRandomKeyCombination();
				Output(randomCombination.ToString());

				pressedKey = Console.ReadKey(true);

				if (KeyPressMatches(pressedKey, randomCombination))
					Output(".");
				else
					Output("*** Fail. You pressed " + new KeyCombination(pressedKey) + "\n\n" );

			} while (pressedKey.Key != ConsoleKey.Escape);
		}

		private static void OutputIntroText()
		{
			Output("TheCore HotKey Trainer");
			Output("----------------------");
			Output("This first version only supports the RRM layout.");
			Output("Press <escape> to exit.");
		}

		private static bool KeyPressMatches(ConsoleKeyInfo pressedKey, KeyCombination randomCombination)
		{
			return pressedKey.Key == randomCombination.Key
			       && pressedKey.Modifiers == randomCombination.AltCtrlShiftKeysPressed;
		}

		private static IKeyboardLayout GetKeyboardLayout()
		{
			return new RandomRightyMedium();
		}

		private static void Output(string msg)
		{
			Console.WriteLine(msg);
		}
	}
}