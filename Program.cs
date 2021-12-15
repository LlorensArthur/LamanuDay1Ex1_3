int firstNumber;
int secondNumber;
Console.WriteLine("Veuillez entrer la valeur du premier nombre : ");
firstNumber = Int32.Parse(Console.ReadLine());
Console.WriteLine("Veuillez entrer la valeur du deuxième nombre : ");
secondNumber = Int32.Parse(Console.ReadLine());
firstNumber += 33;
secondNumber++;
Console.WriteLine($"Le résultat de la division de {firstNumber} par {secondNumber} est : {(float)firstNumber / (float)secondNumber}");