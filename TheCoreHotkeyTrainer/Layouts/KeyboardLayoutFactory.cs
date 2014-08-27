using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoreHotkeyTrainer.Layouts.Righty.Medium;

namespace TheCoreHotkeyTrainer.Layouts
{
	internal class KeyboardLayoutFactory
	{
		private List<IKeyboardLayout> _allLayouts;

		public List<IKeyboardLayout> AllLayouts
		{
			get { return _allLayouts; }
		}

		public KeyboardLayoutFactory()
		{
			_allLayouts = new List<IKeyboardLayout>
			{
				new RandomRightyMedium(),
				new TerranRightyMedium(),
				new ProtossRightyMedium(),
				new ZergRightyMedium(),
			};
		}

		public IKeyboardLayout CreateLayout(string layoutCode)
		{
			return _allLayouts.SingleOrDefault(l => l.ShortCode.Equals(layoutCode, StringComparison.InvariantCultureIgnoreCase));
		}
	}
}
