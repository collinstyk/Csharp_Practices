void PrintPrimeNumbers(int range)
{
    List<int> primeNumbers = new List<int>();

    for (int i = 2; i <= range; i++)
    {
        bool isPrime = true;
        if (primeNumbers.Count == 0)
        {
            Console.WriteLine(i);
            primeNumbers.Add(i);
        }
        else
        {
            foreach (int primeNumber in primeNumbers)
            {
                if (i % primeNumber == 0) isPrime = false;
            }
            if (isPrime) { Console.WriteLine(i); primeNumbers.Add(i); }
        }

    }
}

// Testing out the function
PrintPrimeNumbers(20000);
