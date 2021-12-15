int firstNumber;
int secondNumber;
Console.WriteLine("Veuillez entrer la valeur du premier nombre : ");
while(!int.TryParse(Console.ReadLine(), out firstNumber)){
    Console.WriteLine("Veuillez entrer uniquement un nombre.");
}
Console.WriteLine("Veuillez entrer la valeur du deuxième nombre : ");
while(!int.TryParse(Console.ReadLine(), out secondNumber)){
    Console.WriteLine("Veuillez entrer uniquement un nombre.");
}
firstNumber += 33;
secondNumber++;
Console.WriteLine($"Le résultat de la division de {firstNumber} par {secondNumber} est : {(float)firstNumber / (float)secondNumber}");