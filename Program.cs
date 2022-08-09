int numberA =5;
int numberB =4;
if( numberA>numberB)
  Console.WriteLine("numberA  больше");
else
  Console.WriteLine("numberB больше");
 
int numberC =2;
int numberD =10;
if( numberC>numberD)
  Console.WriteLine("2 больше");
else
  Console.WriteLine("10 больше");

int numberF =-9;
int numberG =-3;
if( numberF>numberG)
  Console.WriteLine("-9 больше");
else
  Console.WriteLine("-3 больше");




int max[] array ={2,3,7};

int result = max(
    max (array[0], array[1], array[2])
);
Console.WriteLine(result);