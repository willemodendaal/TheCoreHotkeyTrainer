using System;
using TheCoreHotkeyTrainer.Layouts;

namespace TheCoreHotkeyTrainer
{
	internal class UserInputGatherer
	{
		private Score _score;
		private readonly IKeyboardLayout _keyboardLayout;

		public UserInputGatherer(Score score, IKeyboardLayout keyboardLayout)
		{
			_score = score;
			_keyboardLayout = keyboardLayout;
		}

		public ConsoleKeyInfo GetSingleUserInput()
		{
			KeyCombination randomCombination = _keyboardLayout.GetRandomKeyCombination();
			Console.WriteLine(randomCombination.ToString());

			DateTime timeBeforeKeyPress = DateTime.Now;
			ConsoleKeyInfo pressedKey = Console.ReadKey(true);
			DateTime timeAfterKeyPress = DateTime.Now;

			if (KeyPressMatches(pressedKey, randomCombination))
			{
				_score.RecordSuccess(timeBeforeKeyPress, timeAfterKeyPress);
			}
			else
			{
				_score.RecordFailure(timeBeforeKeyPress, timeAfterKeyPress);
				Console.WriteLine("*** Fail. You pressed " + new KeyCombination(pressedKey) + "\n\n");
			}
			return pressedKey;
		}

		private static bool KeyPressMatches(ConsoleKeyInfo pressedKey, KeyCombination randomCombination)
		{
			return pressedKey.Key == randomCombination.Key
			       && pressedKey.Modifiers == randomCombination.AltCtrlShiftKeysPressed;
		}
	}
}