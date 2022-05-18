System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

var ran = new Random();

string path = "myFile.txt";

using (StreamWriter writer = new StreamWriter(path))
{
    for (int i = 0; i < 100; i++)
    {
        writer.WriteLine(Math.Round((decimal)ran.NextDouble(), 2));
    }
}