//Implicit Conversion (Bilinçsiz Dönüşüm)
Console.WriteLine("Implicit Conversion ");
byte a = 5;
sbyte b = 30;
short c = 10;

int d = a+b+c;
Console.WriteLine("d: "+ d);

long h = d;
Console.WriteLine("h: " + h);

float i = h;
Console.WriteLine("i: " + i);

string e = "zikriye";
char f = 'k';
object g = e+f+d;
Console.WriteLine("g: " + g );


//Explicit Conversion (Bilinçli Dönüşüm)
Console.WriteLine("Explicit Conversion ");

int x= 4;
byte y = (byte)x;
Console.WriteLine("y: " + y);


int z = 100;
byte t = (byte)z;
Console.WriteLine("t: " + t);


float w = 10.3f;
byte v = (byte)w;
Console.WriteLine("v: " +v);


//ToString
Console.WriteLine("******* ToString Method **********");
int xx = 6;
string yy = xx.ToString();
Console.WriteLine("yy: " +yy);


//System.Convert
Console.WriteLine("******* System.Convert Class **********");
string s1= "10", s2="20";

int number1, number2;
int total;

number1= Convert.ToInt32(s1);
number2= Convert.ToInt32(s2);

total = number1 +number2;
Console.WriteLine("total: " +total);

//Parse
Console.WriteLine("******* Parse **********");
ParseMethod();
void ParseMethod(){
    string title = "10";
    string title1 = "10.25";
    int num1;
    double double1;

    num1 = Int32.Parse(title);
    double1 = double.Parse(title1);

    Console.WriteLine("num1: " +num1);
    Console.WriteLine("double1: " +double1);
}
