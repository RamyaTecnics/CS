using System.Net;
using System.IO;
using System;

class OpenWeather
{
	public void getData()
	{
		Console.Write("Enter city name: ");
		string city = Console.ReadLine();
		string url = String.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid=abe3a0f4d0b6cebfbe7393b4b4e3aa28&units=metric", city);
		HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(url);
		WebResponse response = httpRequest.GetResponse();
		StreamReader reader = new StreamReader(response.GetResponseStream());
		string result = reader.ReadToEnd();
		string subString = "temp";
		int i = (result.IndexOf(subString)) + 6;
		string temp = result.Substring(i, 5);
		Console.WriteLine("Temperature: " + temp);
	}
	public static void Main(String[] args)
	{
		OpenWeather oOpenWeather = new OpenWeather();
		oOpenWeather.getData();
	}
}

