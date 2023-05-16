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
    switch (twoLetterRegionCode){
      case "CH": //Switzerland
        rate = 0.08M;
        break;
      case "DK": //Denmark
      case "NO": //Norway
        rate = 0.25M;
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
}