
Console.WriteLine("Hvornår har du fødselsdag? (ddMMyyyy)");
DateTime birthday = DateTime.ParseExact(Console.ReadLine(), "ddMMyyyy", null);
DateTime now = DateTime.Now;

TimeSpan difference = now - birthday;

int years = (int)Math.Floor(difference.TotalDays / 365.2425);

int days = (int)Math.Floor(difference.TotalDays);

Console.WriteLine("Du er " + years + " år og " + days + " dage gammel");