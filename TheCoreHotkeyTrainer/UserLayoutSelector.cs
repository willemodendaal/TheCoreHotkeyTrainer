using System;
using TheCoreHotkeyTrainer.Layouts;

namespace TheCoreHotkeyTrainer
{
	internal class UserLayoutSelector
	{
		private static KeyboardLayoutFactory _layoutFactory;

		public UserLayoutSelector()
		{
			_layoutFactory = new KeyboardLayoutFactory();
		}

		public IKeyboardLayout GetUserChosenKeyboardLayout()
		{
			IKeyboardLayout chosenLayout = null;
			while (chosenLayout == null)
			{
				OutputLayoutSelectionMenu();
				string layoutCode = Console.ReadLine();
				chosenLayout = _layoutFactory.CreateLayout(layoutCode);

				if (chosenLayout == null)
					Console.WriteLine("That code is invalid, please try again...");
			}

			Console.Clear();
			Console.WriteLine("\nYou chose " + chosenLayout.ShortCode + ". Let's begin...\n");
			Console.WriteLine("Press the key combination shown below.  (or press <Esc> to exit)");

			return chosenLayout;
		}

		private static void OutputLayoutSelectionMenu()
		{
			Console.WriteLine("------------");
			Console.WriteLine("Please type the 3-letter code for the layout you would like to train for:");
			foreach (var layout in _layoutFactory.AllLayouts)
			{
				Console.WriteLine("  " + layout.ShortCode + ":  " + layout.DisplayName);
			}

			Console.Write("> ");
		}
	}
}