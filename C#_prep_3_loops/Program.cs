// See https://aka.ms/new-console-template for more information

/*********************************************************
*
*   Practice with for, foreach, while, do-while loops
*
**********************************************************/

using System;
using System.Collections.Generic;

// // for loop
// for (int i = 0; i < 50; i++){
//     Console.WriteLine(i);
// }

// // for-each loop
// string cars = "Toyota Prius";

// foreach (char letter in cars){
//     Console.WriteLine(letter);
// }

// // While loop
// string input = null;
// while (input != "no"){
//     Console.WriteLine("Stay in the loop? ");
//     input = Console.ReadLine();
// }

// do-while loop
string input2;

do{
    Console.WriteLine("Stay in the loop?");
    input2 = Console.ReadLine();
}while(input2 != "no");

// // Number guesser
// Random rng = new Random();
// int rand_num = rng.Next(1,11);

// Console.WriteLine("What is your guess? ");
// var guess = Console.ReadLine();
// int guess_int = Convert.ToInt32(guess);
// // Console.WriteLine(guess);


// while (guess_int < rand_num){
//     if (guess_int < rand_num){
//         Console.WriteLine("Guess higher!");
//         break;
//     }
//     if (guess_int > rand_num){
//         Console.WriteLine("Guess lower!");
//         break;
//     }
//     if (guess_int == rand_num){
//         Console.WriteLine("You guessed Correctly! ^_^");
//         break;
//     }
// }