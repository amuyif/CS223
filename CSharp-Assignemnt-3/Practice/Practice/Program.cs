// See https://aka.ms/new-console-template for more information
/*#1
for (int i = 1; i < 10; i++)
{
    Console.WriteLine(i);
}
8*/

//#2
//int sum = 0;
/*for (int i = 1; i < 11; i++)
{
    Console.WriteLine(i);
    sum += i;
}
    Console.WriteLine("The sum is"+sum);
*/
//#3
/*Console.WriteLine("Please the number of terms you want added");
int num;
num=int.Parse(Console.ReadLine());
int sum = 0;
for (int i=1; i<=num; i++)
{
    Console.WriteLine(i);
    sum += i;
}
Console.WriteLine("The sum fo the first " + num + " terms is " + sum);
*/
//#4
/*int sum = 0;
int temp = 0;
for (int i=0; i<10; i++)
{
    Console.WriteLine("Please enter term number " + (i + 1));
    temp = int.Parse(Console.ReadLine());
    sum +=temp;
}
Console.WriteLine("The sum is "+sum);
Console.WriteLine("The average is " + sum / 10);
*/
//#5
/*Console.WriteLine("Enter the number");
int num;
num=int.Parse(Console.ReadLine());
for(int i=1; i<=num; i++)
{
    Console.WriteLine("The number is " + i + " and the cube is " + (i * i * i));
}
*/
//#6
Console.WriteLine("Enter the number");
int num;
num=int.Parse(Console.ReadLine());
for(int i=1; i<=10; i++)
{
    Console.WriteLine(num+"*"+i + " = " + num * i);
}