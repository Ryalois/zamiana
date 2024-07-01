using System.IO;
using System.Text.RegularExpressions;

String filename = Console.ReadLine();

String line = "";
try
{
    StreamReader reader = new StreamReader(filename + ".txt");
    StreamWriter writer = new StreamWriter(filename + "_changed.txt");

    line = reader.ReadLine();

    while(line != null)
    {
        String newLIne = Regex.Replace(line, "praca", "job");

        writer.WriteLine(newLIne);
        line = reader.ReadLine();
    }
    writer.Flush();
}
catch(Exception e)
{
    Console.WriteLine(e);
}