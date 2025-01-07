using DiceRollGame;
using DiceRollGame.DiceRollGame;
using System.ComponentModel.DataAnnotations;

//Main


var random = new Random();
var dice = new Dice(random);

var guessingGame = new GuessingGame(dice);


GameResult gameResult = guessingGame.Play();
GuessingGame.PrintResult(gameResult);

Console.ReadKey();
