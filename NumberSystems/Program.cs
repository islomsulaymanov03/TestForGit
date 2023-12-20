using System;

class Dastur
{
	static void Main()
	{
		// Konvertatsiya funksiyalarini sinash
		Console.WriteLine("Ikki sonli sistemadan O'nlik son sistemaga:");
		string ikkiSoni = "1101";
		int onliNatija = IkkiSoniToOnlik(ikkiSoni);
		Console.WriteLine($"{ikkiSoni} ikki sonli sistemada, {onliNatija} o`nli son sistemada");

		Console.WriteLine("\nO'nlik son sistemadan Ikki sonli sistemaga:");
		int onliSoni = 13;
		string ikkiNatija = OnlikSoniToIkki(onliSoni);
		Console.WriteLine($"{onliSoni} o`nli son sistemada, {ikkiNatija} ikki son sistemada");
	}

	// Ikki sonli sistemadan O'nlik son sistemaga konvertatsiya qilish uchun funksiya
	static int IkkiSoniToOnlik(string ikkiSoni)
	{
		int onliNatija = 0;
		int daraja = 0;

		for (int i = ikkiSoni.Length - 1; i >= 0; i--)
		{
			int raqam = ikkiSoni[i] - '0'; // Char ni int ga o'girish
			onliNatija += raqam * (int)Math.Pow(2, daraja);
			daraja++;
		}

		return onliNatija;
	}

	// O'nlik son sistemadan Ikki sonli sistemaga konvertatsiya qilish uchun funksiya
	static string OnlikSoniToIkki(int onliSoni)
	{
		string ikkiNatija = "";

		while (onliSoni > 0)
		{
			int qoldiq = onliSoni % 2;
			ikkiNatija = qoldiq + ikkiNatija;
			onliSoni /= 2;
		}

		return ikkiNatija == "" ? "0" : ikkiNatija;
	}
}
