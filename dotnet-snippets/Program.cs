using myext;

//Fill Space with alias sp()
string sp(int i) => new string(' ', i);

//just strings of different widths
string[] someValues = new[] { "Red", "Green", "Blue", "Pale Orange", "Brown", "Wilted Auburn" };

//Just one hacky method for padded width. 
_ = someValues.All(s => { Console.WriteLine($"{s}{sp(25)[s.Length..]} //next characters...");return true; });

/* Output:
Red                      //next characters...
Green                    //next characters...
Blue                     //next characters...
Pale Orange              //next characters...
Brown                    //next characters...
Wilted Auburn            //next characters...
*/


//just strings of different widths
string[] someMoreValues = new[] { "Red", "Green", "Blue", "Bright Pale Ethereal Orange-ish Green Inverted", "Brown", "Wilted Auburn" };

//5 lines
Console.WriteLine("".PadRight(5, '\r').ReplaceLineEndings());

//Just one hacky method for padded width. Trying larger values. See extension method sksp/"Skip&Space"
_ = someMoreValues.All(s => { Console.WriteLine($"{s.sksp(25)} //next characters..."); return true; });

namespace myext
{
	public static class StrExt
	{
		public static string sksp(this string s, int i) => $"{s}{new string((new string(' ', i).Skip(s.Length).ToArray()))}";
	}
}


//back to chores, ya' slacker!