// See https://aka.ms/new-console-template for more information


static void PlayRPS(){
List<string> lanzar = new List<string>{"Rock", "Paper", "Scissors"};

Random rnd = new Random();

int index = rnd.Next(0, lanzar.Count);

Console.WriteLine("Challenger played: " + lanzar[index]); 
}

static bool CheckResult()
{
    
}

ThreadStart newThread = new ThreadStart(PlayRPS);
