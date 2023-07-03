/*
  in questo esercizio non essendo specificato in che modo dobbiamo ordinare i dati se tramite 
  la "Query syntax" o "Method syntax", io li ho fatti entrambe le maniere
 */

List<int> listOfNumbersRandom = new List<int>();
Random randomNumbers = new Random();

for (int i = 0; i < 1001; i++)
{
    listOfNumbersRandom.Add(randomNumbers.Next(0, 70));
}

Console.WriteLine("sto stampando i numeri presenti nella lista:");

foreach (int x in listOfNumbersRandom)
{
    Console.WriteLine(x);
}

Console.WriteLine("-------------------------------------------------");

Console.WriteLine("Query syntax:\nsto stampando i numeri della lista dal più piccolo al più grande");
List<int> listOfNumersOddQuery = (from numbers in listOfNumbersRandom orderby numbers select numbers).ToList();

foreach (int x in listOfNumersOddQuery)
{
    Console.WriteLine(x);
}

Console.WriteLine("\nQuery syntax:\nsto stampando i numeri della lista dal più grande al più piccolo");
List<int> listOfNumersOddDescending = (from numbers in listOfNumbersRandom orderby numbers descending select numbers).ToList();

foreach (int x in listOfNumersOddDescending)
{
    Console.WriteLine(x);
}


Console.WriteLine("-------------------------------------------------");

Console.WriteLine("Method syntax:\nsto stampando i numeri della lista dal più piccolo al più grande");
List<int> listOfNumersOddMethod = listOfNumbersRandom.OrderBy(numbers => numbers).ToList();

foreach (int x in listOfNumersOddMethod)
{
    Console.WriteLine(x);
}


Console.WriteLine("\nMethod syntax:\nsto stampando i numeri della lista dal più grande al più piccolo");
List<int> listOfNumersOddMethodDescending = listOfNumbersRandom.OrderByDescending(numbers => numbers).ToList();

foreach (int x in listOfNumersOddMethodDescending)
{
    Console.WriteLine(x);
}










