using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoreHotkeyTrainer.Layouts;
using TheCoreHotkeyTrainer.Layouts.Righty.Medium;

namespace TheCoreHotkeyTrainer
{
	internal class Program
	{
		private static readonly UserLayoutSelector _userLayoutSelector;
		private static UserInputGatherer _inputGatherer;
		private static Score _score;

		static Program()
		{
			_userLayoutSelector = new UserLayoutSelector();
			_score = new Score();
		}

		private static void Main()
		{
			OutputIntroText();

			ConsoleKeyInfo pressedKey;

			IKeyboardLayout keyboardLayout = _userLayoutSelector.GetUserChosenKeyboardLayout();
			Console.TreatControlCAsInput = true;
			_inputGatherer =
			 new UserInputGatherer(_score, keyboardLayout);
			DateTime startTime = DateTime.Now;
			do
			{
				pressedKey = _inputGatherer.GetSingleUserInput();
			} while (pressedKey.Key != ConsoleKey.Escape);
			DateTime endTime = DateTime.Now;

			Console.WriteLine("\nWell done! Here are your results:");
			Console.WriteLine(_score.GetScoreSummaryString());
			Console.WriteLine("Time practiced: " + (endTime - startTime).ToString(@"hh\:mm\:ss"));
			Console.ReadKey();
		}

		private static void OutputIntroText()
		{
			Console.WriteLine("TheCore HotKey Trainer");
			Console.WriteLine("\tPress <escape> to exit.");
		}
	}
}