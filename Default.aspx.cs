using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

			string result = "";
			int indexAtMax = 0;
			int indexAtMin = 0;

			// THIS WORKS TOO. hi
			//int MaximumOfNumbers = numbers.Max();
			//int indexOfMaximum = numbers.ToList().IndexOf(MaximumOfNumbers);

			for (int i = 0; i < numbers.Length; i++)
			{
				int MaximumOfNumbers = numbers.Max();
				int MinimumOfNumbers = numbers.Min();

				if (numbers[i] == MaximumOfNumbers)
				{
					indexAtMax = i;
				}

				if (numbers[i] == MinimumOfNumbers)
				{
					indexAtMin = i;
				}

				 result = String.Format("Most battles won: {0} with {1} <br/> Fewest battles won: {2} with {3}", names[indexAtMax], numbers[indexAtMax], names[indexAtMin], numbers[indexAtMin]);
				 resultLabel.Text = result;
			}	
        }
    }
}