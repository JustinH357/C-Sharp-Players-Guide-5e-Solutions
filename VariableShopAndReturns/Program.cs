int number = 1;
byte byteNumber = 34;
short shortNumber = 5039;
long longNumber = 322912262579;
sbyte sByteNumber = -12;
ushort uShortNumber = 60000;
uint uIntNumber = 2200600200;
ulong uLongNumber = 8180000000000000;
float floatNumber = 5f;
string stringWord = "hello";
bool aBool = true;
char charLetter = 'a';
double doubleNumber = 1.5;
decimal decimalNumber = 2.5m;

void VariablesDisplay()
{
    Console.WriteLine("All 14 Variables:");
    Console.WriteLine($"Float: {floatNumber} \nString: {stringWord} \nDouble: {doubleNumber}" +
                      $"\nByte: {byteNumber} \nShort: {shortNumber} \nLong: {longNumber}" +
                      $"\nInt: {number} \nSbyte: {sByteNumber} \nUshort: {uShortNumber}" +
                      $"\nUint: {uIntNumber} \nUlong: {uLongNumber} \nBool: {aBool} " +
                      $"\nChar: {charLetter} \nDecimal: {decimalNumber}");
}

void ModifiedVariableDisplay()
{
    Console.WriteLine("\nModified Variables:");
    Console.WriteLine($"Float: {floatNumber = 2f} \nString: {stringWord = "Hello World"} " +
                      $"\nDouble: {doubleNumber = 1.2}" + $"\nByte: {byteNumber = 125} " +
                      $"\nShort: {shortNumber = -30_000} \nLong: {longNumber = 8_000_000_000_000_000}" +
                      $"\nInt: {number = 10} \nSbyte: {sByteNumber = 115} \nUshort: {uShortNumber = 41500}" +
                      $"\nUint: {uIntNumber = 2_000_222_000} \nUlong: {uLongNumber = 18_200_000_000_000_000} " +
                      $"\nBool: {aBool = false} " + $"\nChar: {charLetter = 'b'} " +
                      $"\nDecimal: {decimalNumber = 0.6m}");  