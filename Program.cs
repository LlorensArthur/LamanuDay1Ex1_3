﻿int firstNumber;
int secondNumber;
string firstString = "5.682";
string secondString = "4.137";
float flt1 = float.Parse(firstString);
float flt2 = float.Parse(secondString);
Console.WriteLine("Veuillez entrer la valeur du premier nombre : ");
firstNumber = Int32.Parse(Console.ReadLine());
Console.WriteLine("Veuillez entrer la valeur du deuxième nombre : ");
secondNumber = Int32.Parse(Console.ReadLine());
firstNumber += 33;
secondNumber++;
Console.WriteLine($"Le résultat de la division de {firstNumber} par {secondNumber} est : {(float)firstNumber / (float)secondNumber}");