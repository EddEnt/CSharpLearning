
//Mainly used in money or very, very accurate systems (NASA, space based systems)
decimal bankAccountBalance; //Much more accurate than double, stores numbers rounded to 28 positions

//bankAccountBalance = 2.34; compiler will convert variable into a double, must declare it with an M at the end of the declaration
bankAccountBalance = 2.34M;

Console.WriteLine(bankAccountBalance);

