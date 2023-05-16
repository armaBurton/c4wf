partial class Program{
  static void TimesTable(byte number, byte size = 12){
    WriteLine($"This is the {number} times table with {size} rows");
    for (int row = 1; row <= size; row++){
      WriteLine($"{row} x {number} = {row * number}");
    }
    WriteLine($"");
  }

  static decimal CalculateTax(
    decimal amount,
    string twoLetterRegionCode
  ){
    decimal rate = 0.0M;
    switch (twoLetterRegionCode){
      case "CH": //Switzerland
        rate = 0.08M;
        break;
      case "DK": //Denmark
      case "NO": //Norway
        rate = 0.25M;
        break;
      case "GB":
      case "FR":
        rate = 0.2M;
        break;
      case "HU": //Hungary
        rate = 0.27M;
        break;
      case "OR":
      case "AK":
      case "MT":
        rate = 0.0M;
        break;
      case "ND":
      case "WI":
      case "ME":
      case "VA":
        rate = 0.05M;
        break;
      case "CA":
        rate = 0.0825M;
        break;
      default:
        rate = 0.06M;
        break;
    }
    return amount * rate;
  }

  static string CardinalToOrdinal(int number){
    int lastTwoDigits = number % 100;

    switch(lastTwoDigits){
      case 11:
      case 12:
      case 13:
        return $"{number:N0}th";
      default:
      int lastDigit = number % 10;
      
      string suffix = lastDigit switch {
        1 => "st",
        2 => "nd",
        3 => "rd",
        _ => "th"
      };

    return $"{number:N0}{suffix}";
    }
  }

  static void RunCardinalToOrdinal(){
    for (int number = 1; number <= 150; number++){
      Write($"{CardinalToOrdinal(number)} ");
    }
  }

  static int Factorial(int number){
    if (number < 0){
      throw new ArgumentException(message:
        $"The factorial function is defined for non-negative integers only. Input {number}",
        paramName: nameof(number));
    } else if (number == 0){
      return 1;
    } else {
      return number * Factorial(number - 1);
    }
  }

  static void RunFactorial(){
    for (int i = 1; i <= 15; i++){
      WriteLine($"{i}! = {Factorial(i)}");
    }
  }

}