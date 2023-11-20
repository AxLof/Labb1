//Arrayer som innehåller namn och ålder
int[] age = new int[4];
string[] names = new string[4];


//Forloop som frågar efter namn och ålder, samt lagrar inputen


for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine("Skriv namnet på person " + (i+1));
    names[i] = Console.ReadLine();

    Console.WriteLine("Skriv in åldern på person " + (i+1));
    age[i] = Convert.ToInt32(Console.ReadLine());

}



//Adderar alla åldrar och skriver ur hur gamla alla är
double ageSum = 0;
for(int i = 0; i < age.Length; i++)
{
    ageSum += age[i];
    Console.WriteLine(names[i] + " är " + age[i] + " år gammal.");

}

//Skriver ut sammanlagd ålder samt medelålder. 

Console.WriteLine("Den sammanlagda åldern är: " +  ageSum);

double medianAge = ageSum / age.Length;
Console.WriteLine("Medelåldern är: {0:0.00}", medianAge);