## Exercise 1:

Create a program that allows a user to play a game where they must guess what your favorite number is:

* Initialize an integer to represent a favorite number and assign a value with a number of your choosing or you can assign a random number to this variable:

```
var r = new Random();
var favNumber = r.Next(1,1000);
var userInput = int.Parse(Console.ReadLine());
``` 

The following code will allow the user to guess what your favorite number is:
```
var userInput = int.Parse(Console.ReadLine());
```

+ Create an if-statement that if the guessed number is below the initial value, print out “too low”.

+ Create an else-if statement that if the number is higher than the initial value, print out “too high”.

+ Create an else statement that prints out some type of congratulations for guessing the correct number e.g. “You guessed it!!!”.

Remember to save, commit, and push back to Github once complete

## Extra Switch Statement Practice:

[https://www.codewars.com/kata/568dc014440f03b13900001d/train/csharp](https://www.codewars.com/kata/568dc014440f03b13900001d/train/csharp)
 