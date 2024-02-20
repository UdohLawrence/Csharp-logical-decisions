//Install and configure Visual Studio Code
//Console.WriteLine("Hello, C#!");


//Call methods from the .Net Class Library using C#endregion
// Random dice = new Random();
// int roll = dice.Next(1,7);
// Console.WriteLine(roll);

//int result = Random.Next();

/*
Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");
*/
/*
int firstValue = 500;
int secondValue = 600;

int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);
*/
/*

ADD LOGICAL DECISIONS TO CODE

Random dice = new Random();
int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

int total = roll1+roll2+roll3;
Console.WriteLine($"Dice Roll: {roll1} + {roll2} + {roll3} = {total}.");

if((roll1 == roll2) || (roll2 == roll3) || (roll3 == roll1)){
    Console.WriteLine("You rolled doubles! +2 bonus to total");
    total += 2;
}
if ((roll1 == roll2) && (roll2 == roll3)){
    Console.WriteLine("You rolled triples! +6 bonus to total");
    total += 6;
}
if (total >= 15){
    Console.WriteLine("You win!");
}
if(total < 15){
    Console.WriteLine("Sorry, you lose!");
}
*/

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

//TEST THE CODE'S LOGIC
//roll1 = 5;
//roll2 = 5;
//roll3 = 5;

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)){
    if ((roll1 == roll2) && (roll2 == roll3)){
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }else {
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
    }
}

if (total >= 16){
    Console.WriteLine("You win a Car!");
} else if (total >= 10){
    Console.WriteLine("You win a new laptop.");
} else if (total == 7){
    Console.WriteLine("You win a trip for two.");
} else {
    Console.WriteLine("You win a kitten");
}
