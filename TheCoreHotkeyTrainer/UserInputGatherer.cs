using System;
using TheCoreHotkeyTrainer.Layouts;

namespace TheCoreHotkeyTrainer
{
	internal class UserInputGatherer
	{
		private Score _score;
		private readonly IKeyboardLayout _keyboardLayout;
		private const int TrainingPromptPosition = 12;
		private const int ErrorPromptPosition = 13;

		public UserInputGatherer(Score score, IKeyboardLayout keyboardLayout)
		{
			_score = score;
			_keyboardLayout = keyboardLayout;
		}

		public ConsoleKeyInfo GetSingleUserInput()
		{
			KeyCombination randomCombination = _keyboardLayout.GetRandomKeyCombination();
			OutputOnTrainingPromptRow(randomCombination);

			DateTime timeBeforeKeyPress = DateTime.Now;
			ConsoleKeyInfo pressedKey = Console.ReadKey(true);
			ClearErrorRow();
			DateTime timeAfterKeyPress = DateTime.Now;

			if (KeyPressMatches(pressedKey, randomCombination))
			{
				_score.RecordSuccess(timeBeforeKeyPress, timeAfterKeyPress);
			}
			else if (pressedKey.Key == ConsoleKey.Escape)
			{
				// Do nothing, this is ok.
			}
			else
			{
				_score.RecordFailure(timeBeforeKeyPress, timeAfterKeyPress);
				OutputOnErrorRow(pressedKey);
			}
			return pressedKey;
		}

		private void ClearErrorRow()
		{
			Console.SetCursorPosition(0, ErrorPromptPosition);
			Console.WriteLine("                                                ");
		}

		private static void OutputOnTrainingPromptRow(KeyCombination randomCombination)
		{
			Console.ForegroundColor = ConsoleColor.White;
			Console.SetCursorPosition(0, TrainingPromptPosition); 
			Console.WriteLine("\t" + randomCombination + "                       ");

			Console.ResetColor();
		}

		private static void OutputOnErrorRow(ConsoleKeyInfo pressedKey)
		{
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.SetCursorPosition(0, ErrorPromptPosition); 
			Console.WriteLine("\t* Oops. You pressed " + new KeyCombination(pressedKey) + "         ");

			Console.ResetColor();
		}


		private static bool KeyPressMatches(ConsoleKeyInfo pressedKey, KeyCombination randomCombination)
		{
			return pressedKey.Key == randomCombination.Key
			       && pressedKey.Modifiers == randomCombination.AltCtrlShiftKeysPressed;
		}
	}
}