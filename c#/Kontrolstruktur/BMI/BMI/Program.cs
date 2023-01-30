Console.WriteLine("Hvad er din højde i m?");
double height = double.Parse(Console.ReadLine());
Console.WriteLine(height);

Console.WriteLine("Hvad er din vægt i kg?");
double Weight = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Weight);

double bmi = (Weight / (height * height));

Console.WriteLine("Din bmi er: " + bmi);



if (bmi < 18.5)
{
    Console.WriteLine("Du er undervægtig");
}

else if (bmi > 18.5 && bmi <24)
{
    Console.WriteLine("Du er normal");
}

else if(bmi > 24 && bmi < 30) 
{
    Console.WriteLine("Du er overvægtig");
}

else if(bmi > 30 && bmi < 35) 
{
    Console.WriteLine("Du er 1 grads overvægtig");
}

else if(bmi > 35 && bmi < 40)
{
    Console.WriteLine("Du er 2 grads overvægtig");
}

else if (bmi > 40) 
{
    Console.WriteLine("Du er 3 grads overvægtig");
}