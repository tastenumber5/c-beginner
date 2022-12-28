
using System.Collections.Concurrent;
using System.Threading.Channels;
using StudentApplication;

int studentId = 0;
string firstname = string.Empty;
string lastname = string.Empty;
decimal loanAmount = 0;
char gender = '\0';
bool isNew = false;

Console.WriteLine("Enter your student Id");
studentId = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your firstname");
firstname = Console.ReadLine();

Console.WriteLine("Enter your lastname");
lastname = Console.ReadLine();

string studentFullName = $"{firstname} {lastname}";

Console.WriteLine($"{studentFullName} What is your current loan amount?");
loanAmount = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"What is your gender ('f' female or 'm' male )");
gender = Convert.ToChar(Console.ReadLine());

Console.WriteLine($"{studentFullName} is a new student (true|false)");
isNew = Convert.ToBoolean(Console.ReadLine());

Console.Clear();

Student student = new Student(studentId, firstname, lastname, loanAmount, gender, isNew);


Console.Clear();

Student studentCopy = student;

Console.WriteLine("Student data  " + student.StudentData());

Console.WriteLine();

Console.WriteLine("Student copy data  " + studentCopy.StudentData());

Console.WriteLine();

Console.WriteLine("Please update the student's loan amount");

student.UpdateLoanAmount(Convert.ToDecimal(Console.ReadLine()));

string dividerText = "After loan update";

Console.WriteLine(new String('-', dividerText.Length));
Console.WriteLine(dividerText);
Console.WriteLine(new String('-', dividerText.Length));

Console.WriteLine("Student data  " + student.StudentData());

Console.WriteLine();

Console.WriteLine("Student copy data  " + studentCopy.StudentData());

Console.ReadKey();


Console.ReadKey();