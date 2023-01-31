int[] vin = { 175134, 175388, 172818, 142709, 151437, 152620, 150979, 152210, 149450, 154398, 150160 };

const int max = 186411;
const byte maxStar = 100;

vin[6] = vin[6] + 35432;

Array.Sort(vin);

for (int i = 0; i < vin.Length; i++)
{
    int star = maxStar * vin[i] / max;

    for (int a = 0; a < star; a++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
