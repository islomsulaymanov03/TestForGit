using System;

class Dastur
{
	static void Main()
	{
		// Konvertatsiya funksiyalarini sinash
		Console.WriteLine("Ikki sonli sistemadan O'nlik son sistemaga:");
		string ikkiSoni = "1101";
		int onliNatija = Convert.ToInt32(ikkiSoni, 2);
		Console.WriteLine($"{ikkiSoni} ikki sonli sistemada, {onliNatija} o`nli son sistemada");

		Console.WriteLine("\nO'nlik son sistemadan Ikki sonli sistemaga:");
		int onliSoni = 13;
		string ikkiNatija = Convert.ToString(onliSoni, 2);
		Console.WriteLine($"{onliSoni} o`nli son sistemada, {ikkiNatija} ikki son sistemada");

		Console.WriteLine("\nIkki sonli sistemadan 8 son sistemaga:");
		string ikkiSoniOktal = "1101";
		string oktalNatija = Convert.ToString(Convert.ToInt32(ikkiSoniOktal, 2), 8);
		Console.WriteLine($"{ikkiSoniOktal} ikki sonli sistemada, {oktalNatija} 8 son sistemada");

		Console.WriteLine("\n8 son sistemadan Ikki sonli sistemaga:");
		string oktalSoni = "15";
		string ikkiNatijaOktal = Convert.ToString(Convert.ToInt32(oktalSoni, 8), 2);
		Console.WriteLine($"{oktalSoni} 8 son sistemada, {ikkiNatijaOktal} ikki son sistemada");

		Console.WriteLine("\nO'nlik son sistemadan 16 son sistemaga:");
		int onliSoniHex = 255;
		string hexNatija = onliSoniHex.ToString("X");
		Console.WriteLine($"{onliSoniHex} o`nli son sistemada, {hexNatija} 16 son sistemada");

		Console.WriteLine("\n16 son sistemadan O'nlik son sistemaga:");
		string hexSoni = "1F";
		int onliNatijaHex = Convert.ToInt32(hexSoni, 16);
		Console.WriteLine($"{hexSoni} 16 son sistemada, {onliNatijaHex} o`nli son sistemada");
	}
}
