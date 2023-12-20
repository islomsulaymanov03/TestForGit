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

		Console.WriteLine("\nIkki sonli sistemadan 8 son sistemaga:");
		string ikkiSoniOktal = "1101";
		string oktalNatija = IkkiSoniToOktal(ikkiSoniOktal);
		Console.WriteLine($"{ikkiSoniOktal} ikki sonli sistemada, {oktalNatija} 8 son sistemada");

		Console.WriteLine("\n8 son sistemadan Ikki sonli sistemaga:");
		string oktalSoni = "15";
		string ikkiNatijaOktal = OktalToIkki(oktalSoni);
		Console.WriteLine($"{oktalSoni} 8 son sistemada, {ikkiNatijaOktal} ikki son sistemada");

		Console.WriteLine("\nO'nlik son sistemadan 16 son sistemaga:");
		int onliSoniHex = 255;
		string hexNatija = OnlikSoniToHex(onliSoniHex);
		Console.WriteLine($"{onliSoniHex} o`nli son sistemada, {hexNatija} 16 son sistemada");

		Console.WriteLine("\n16 son sistemadan O'nlik son sistemaga:");
		string hexSoni = "1F";
		int onliNatijaHex = HexToOnlik(hexSoni);
		Console.WriteLine($"{hexSoni} 16 son sistemada, {onliNatijaHex} o`nli son sistemada");
	}

	// Ikki sonli sistemadan O'nlik son sistemaga konvertatsiya qilish uchun funksiya
	static int IkkiSoniToOnlik(string ikkiSoni)
	{
		int onliNatija = 0;
		int daraja = 0;

		for (int i = ikkiSoni.Length - 1; i >= 0; i--)
		{
			int raqam = ikkiSoni[i] - '0'; // Char ni int ga o'girish
			onliNatija += raqam * Power(2, daraja);
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

	// Ikki sonli sistemadan 8 son sistemaga konvertatsiya qilish uchun funksiya
	static string IkkiSoniToOktal(string ikkiSoni)
	{
		int onliNatija = IkkiSoniToOnlik(ikkiSoni);
		return OnlikSoniToOktal(onliNatija);
	}

	// 8 son sistemadan Ikki sonli sistemaga konvertatsiya qilish uchun funksiya
	static string OktalToIkki(string oktalSoni)
	{
		int onliNatija = OktalToOnlik(oktalSoni);
		return OnlikSoniToIkki(onliNatija);
	}

	// O'nlik son sistemadan 16 son sistemaga konvertatsiya qilish uchun funksiya
	static string OnlikSoniToHex(int onliSoni)
	{
		string hexNatija = "";
		while (onliSoni > 0)
		{
			int qoldiq = onliSoni % 16;
			hexNatija = (qoldiq < 10 ? (char)(qoldiq + '0') : (char)(qoldiq - 10 + 'A')) + hexNatija;
			onliSoni /= 16;
		}
		return hexNatija == "" ? "0" : hexNatija;
	}

	// 16 son sistemadan O'nlik son sistemaga konvertatsiya qilish uchun funksiya
	static int HexToOnlik(string hexSoni)
	{
		int onliNatija = 0;
		for (int i = 0; i < hexSoni.Length; i++)
		{
			char harf = hexSoni[i];
			int raqam = (harf >= 'A' && harf <= 'F') ? (harf - 'A' + 10) : (harf - '0');
			onliNatija = onliNatija * 16 + raqam;
		}
		return onliNatija;
	}

	// Darajani hisoblash uchun funktsiya
	static int Power(int asos, int daraja)
	{
		int natija = 1;
		for (int i = 0; i < daraja; i++)
		{
			natija *= asos;
		}
		return natija;
	}

	// O'nlik son sistemadan 8 son sistemaga konvertatsiya qilish uchun funksiya
	static string OnlikSoniToOktal(int onliSoni)
	{
		string oktalNatija = "";
		while (onliSoni > 0)
		{
			int qoldiq = onliSoni % 8;
			oktalNatija = qoldiq + oktalNatija;
			onliSoni /= 8;
		}
		return oktalNatija == "" ? "0" : oktalNatija;
	}

	// Oktal son sistemadan O'nlik son sistemaga konvertatsiya qilish uchun funksiya
	static int OktalToOnlik(string oktalSoni)
	{
		int onliNatija = 0;
		for (int i = 0; i < oktalSoni.Length; i++)
		{
			int raqam = oktalSoni[i] - '0';
			onliNatija = onliNatija * 8 + raqam;
		}
		return onliNatija;
	}
}
