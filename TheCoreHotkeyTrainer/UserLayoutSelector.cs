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

			Console.WriteLine("\nYou chose " + chosenLayout.ShortCode + ". Let's begin...\n");

			return chosenLayout;
		}

		private static void OutputLayoutSelectionMenu()
		{
			Console.WriteLine("------------");
			Console.WriteLine("Please type the 3-letter code for the layout you would like to train for:");
			foreach (var layout in _layoutFactory.AllLayouts)
			{
				Console.WriteLine("\t" + layout.ShortCode + " - " + layout.DisplayName);
			}
		}
	}
}