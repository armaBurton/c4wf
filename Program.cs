
double a = 4.5,
       b = 2.5;
double answer = Add(a, b);

WriteLine($"{a} + {b} = {answer}");
WriteLine($"Press ENTER to end the app.");

static double Add(double a, double b){
  return a + b; //deliberate bug
}

// RunFibImperative();

// RunFactorial();

// RunCardinalToOrdinal();

// //Tax Calculator
// decimal taxToPay = CalculateTax(amount: 149, twoLetterRegionCode: "FR");
// WriteLine($"you must pay {taxToPay:C} in tax.");

// TimesTable(7, 20);