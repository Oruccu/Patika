Console.WriteLine("Are you ready? Subject: Operators");

int x = 3;
int y = 3;

y = y + 2; //3+2
Console.WriteLine(y);

y += 2; //5+2
Console.WriteLine(y);

y /= 7;
Console.WriteLine(y);

x *= 2;
Console.WriteLine(x);

//Logical Opetators
// ||, &&, |

bool isSuccess = true;
bool isCompleted = false;

if (isSuccess && isCompleted) //and
{
    Console.WriteLine("Perfect");
}

if (isSuccess || isCompleted) //or
{
    Console.WriteLine("Great");
}

if (isSuccess || !isCompleted) //true and!false
{
    Console.WriteLine("Fine");
}

//Relational Operators
// <, >, <=, >=, ==, !=

int a = 3;
int b = 4;

bool result = a > b;
Console.WriteLine(result);




