using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace SumEnteredNumbers
{
	class SumEnteredNumbers
	{

		static void Main( string[] args )
		{
			var sum = 0;
			while( true )
			{
				Console.WriteLine("Enter Number. Type \"ok\" to exit");
				var input = Console.ReadLine();

				if( input.ToLower() == "ok" )
					break;

				sum += Convert.ToInt32(input);

			}

			Console.WriteLine( "Sum of entered numbers is: " + sum );

		}
	}
}
