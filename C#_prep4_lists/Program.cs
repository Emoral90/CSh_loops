// See https://aka.ms/new-console-template for more information

/*
*
*   Practice creating and adding to lists, and list methods
*
*/

// Library for lists
using System;
using System.Collections.Generic;

// Instantiate the list with List<int> nums;
// Instantiate a variable and save the previously created list with that variable. = new List<int>();
List<int> nums = new List<int>();
List<string> strs = new List<string>();

strs.Add("Toyota");
strs.Add("Honda");
strs.Add("Nissan");

Console.WriteLine(strs);
