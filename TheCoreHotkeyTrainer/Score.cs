using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCoreHotkeyTrainer
{
	internal class Score
	{
		public int CorrectCount { get; set; }
		public int IncorrectCount { get; set; }
		public double TotalWaitTimeMilliseconds { get; set; }

		public double AvgWaitTimePerKeyMilliseconds
		{
			get { return TotalWaitTimeMilliseconds/(CorrectCount + IncorrectCount); }
		}

		public string GetScoreSummaryString()
		{
			string timespanFormatted = TimeSpan.FromMilliseconds(TotalWaitTimeMilliseconds).ToString(@"hh\:mm\:ss");

			return string.Format("Correct: {0}\nIncorrect: {1}\nAvg Response(ms): {2}\nPractice time: {3}", 
					CorrectCount, 
					IncorrectCount, 
					AvgWaitTimePerKeyMilliseconds, 
					timespanFormatted);
		}

		public void RecordSuccess(DateTime timeBeforeKeyPress, DateTime timeAfterKeyPress)
		{
			CorrectCount++;
			UpdateTotalWaitTime(timeBeforeKeyPress, timeAfterKeyPress);
		}

		public void RecordFailure(DateTime timeBeforeKeyPress, DateTime timeAfterKeyPress)
		{
			IncorrectCount++;
			UpdateTotalWaitTime(timeBeforeKeyPress, timeAfterKeyPress);
		}

		private void UpdateTotalWaitTime(DateTime timeBeforeKeyPress, DateTime timeAfterKeyPress)
		{
			TotalWaitTimeMilliseconds += (timeAfterKeyPress - timeBeforeKeyPress).TotalMilliseconds;
		}


	}
}
