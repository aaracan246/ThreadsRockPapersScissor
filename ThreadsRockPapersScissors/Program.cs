// See https://aka.ms/new-console-template for more information


static string PlayRPS(){
List<string> lanzar = new List<string>{"Rock", "Paper", "Scissors"};

Random rnd = new Random();

int index = rnd.Next(0, lanzar.Count);

return "Challenger played: " + lanzar[index]; ;
};


ThreadStart newThread = new ThreadStart();