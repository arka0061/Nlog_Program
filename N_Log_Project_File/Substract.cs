using System;
namespace NLog_Project
{
	public class Substract
	{
		static NLog nlog = new NLog();
		public static int Sub(int first_number, int second_number)
		{
			if (first_number == 0 || second_number == 0)
			{
				nlog.LogInfo("Sub method");
				nlog.LogDebug("Debug Sucessful");
				nlog.LogError("First number or second number is zero");
				return 0;
			}
			int result = second_number - first_number;
			Console.WriteLine(result);
			nlog.LogInfo("Sub method");
			nlog.LogDebug("Debug Sucessful");
			if (first_number < 0 || second_number < 0)
			{
				nlog.LogWarn("Warning: one of the numbers is negative");
			}
			return result;
		}
	}
}
