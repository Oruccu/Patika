int number = 12 ; 
Console.WriteLine(number);

int Number = 2;
Console.WriteLine(Number);

string Patika = "test";
Console.WriteLine(Patika);

//string Patika = "test1"; //warning
//string Patika+Test

//String name = " "; white space
byte b = 5;         //1 byte
sbyte c = 5;        //1 byte
                    //byte 0  255 değer alır
                    // sybte -128 ile 127 değer alır

short s = 4;        //2 byte   
                    //short -32bin +32bin

ushort us= 5;       //2byte
Int16 i16 = 2;      //2byte
int i = 2;          //4byte
Int32 i32 = 2;      //4byte
Int64 i64 = 2;      //8byte

uint ui = 2;        //4byte
long l =  4;        //8byte
ulong ul = 4;       //8byte

//reel number
float f= 5;         //4byte 
double d= 5;        //8byte
decimal de= 5;      //16byte

char ch = '2' ;     //2byte
string str ="Ayse";  //Sınırsız

bool b1 = true;
bool b2 = false;

DateTime dt= DateTime.Now;
Console.WriteLine(dt);

object o1 = "x";
object o2 = 'y';
object o3 = 4;
object o4 = 4.3;

//string 

string str1 = null;
string str2 = string.Empty;
str2 = "Ayse";

string name = "Ayse";
string surname = "Nur";
string fullname = name + " " + surname;

//İnteger

int int1 = 5;
int int2 = 2;
int result = int1 * int2;

bool b3= 10<2;

//variable Transformations
string str20 = "20";
int int20 = 20;

string newdata = str20 + int20.ToString();
Console.WriteLine(newdata);

int int21 = int20 + Convert.ToInt32(str20);
Console.WriteLine(int21);

int int22 = int20 + int.Parse(str20);
Console.WriteLine(int22);

//DateTime

string datetime = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(datetime);

string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
Console.WriteLine(datetime2);

string hour = DateTime.Now.ToString("HH:mm");
Console.WriteLine(hour);