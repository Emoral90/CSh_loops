// See https://aka.ms/new-console-template for more information


// int[] myList = new int[10];
// numArray = null;

// for (int i = 0; i < 10; i++ ){
//     Random rng = new Random();
//     int num = rng.Next(1,11);

//     List<int> myList = new List<int>();
//     myList.Append(num);

//     // return myList;
//     Console.WriteLine(List<int>,myList);

//     // numArray = numArray.Append(num).ToArray();

// }

/*********************************************************
*
*   Practice with for, foreach, while, do-while loops
*
**********************************************************/

using System;
using System.Collections.Generic;

// for loop
for (int i = 0; i < 50; i++){
    Console.WriteLine(i);
}

// for-each loop
string cars = "Toyota Prius";

foreach (char letter in cars){
    Console.WriteLine(letter);
}

// While loop
string input = null;
while (input != "no"){
    Console.WriteLine("Stay in the loop? ");
    input = Console.ReadLine();
}

// Number guesser
Random rng = new Random();
int rand_num = rng.Next(1,11);

Console.WriteLine("What is your guess? ");
var guess = Console.ReadLine();
int guess_int = Convert.ToInt32(guess);
// Console.WriteLine(guess);


while (guess_int < rand_num){
    if (guess_int < rand_num){
        Console.WriteLine("Guess higher!");
        break;
    }
    if (guess_int > rand_num){
        Console.WriteLine("Guess lower!");
        break;
    }
    if (guess_int == rand_num){
        Console.WriteLine("You guessed Correctly! ^_^");
        break;
    }
}


// "=================================================================================";