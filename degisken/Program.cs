// See https://aka.ms/new-console-template for more information
Console.WriteLine("");

byte b = 5;
sbyte c = 5;


short s = 5;
ushort us = 5;


Int16 i16 = 2;
int i =2;
Int32 i32 = 2;
Int64 i64 = 2;

uint ui = 2;
long l = 4;
ulong ul = 4;

float f = 5;
double d = 5;
decimal de = 5;

char ch = '2';
string str = "irfan";
 
bool b1 = true;
bool b2= false;

DateTime dt = DateTime.Now;

Console.WriteLine(dt);

object o1 = "x";
object o2 = 'y';
object o3 = 4;
object o4 = 4.3;

string str1 = string.Empty;
str1 = "irfan Ayaz";
string ad = "irfan";
string soyad = "ayaz";
string tamisim = ad + " " + soyad;

int integer1 = 5;
int integer2 = 3;
int integer3 = integer1 * integer2;

bool bool1 = 10>2;

string str20 = "20";
int int20 = 20;

string yenideger = str20 + int20.ToString();

Console.WriteLine(yenideger);

int int21 = int20 + Convert.ToInt32(str20);
Console.WriteLine(int21);

int int22 = int20 + int.Parse(str20);


string Datetime = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(Datetime);

string Datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
Console.WriteLine(Datetime2);

string hour = DateTime.Now.ToString("HH.mm");
Console.WriteLine(hour);

