// See https://aka.ms/new-console-template for more information
using BirdExercise;
using static BirdExercise.Duck;

Random random = new Random();

List<Duck> ducks = new List<Duck>();
    string duckName ="Kaczka";
for (int i = 0; i < 6; i++)
{
    ducks.Add(new Duck() { Kind = (KindOfDuck)random.Next(3),Size = random.Next(12,25)});
}
IEnumerable<Bird> upcastDucks = ducks;


List<Bird> birds = new List<Bird>() { new Bird() { Name = "Feathers" }, new Bird() { Name = "Kuku" } };
birds.AddRange(upcastDucks);
birds.Add(new Penguin() { Name = "George" });
foreach (var bird in birds)
    Console.WriteLine(bird);

Card cardToCheck = new Card(Suits.Clubs, Values.Jack);
bool doesItMach = Card.DoesCardMatch(cardToCheck, Suits.Hearts);
Console.WriteLine(doesItMach);
Console.WriteLine(Card.DoesCardMatch(cardToCheck, Values.Seven));
Console.ReadKey();
