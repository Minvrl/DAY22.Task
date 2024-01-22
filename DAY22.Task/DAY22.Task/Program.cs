using DAY22.Task;


string fullname;
string groupno;
string ageStr;
byte age;

do
{
    Console.Write("Telebenin ad,soyadini daxil edin - ");
    fullname = Console.ReadLine();

} while (!Student.CheckFullname(fullname));

do
{
    Console.Write(" Qrup nomresini daxil edin - ");
    groupno = Console.ReadLine();   

} while (!Student.CheckGroupNo(groupno));

do
{
    Console.Write("  Yasini daxil edin - ");
    ageStr = Console.ReadLine();    

} while (!byte.TryParse(ageStr, out age) || age < 0 );

Student student = new Student() { Fullname = Student.CapitalizeFullname(fullname),GroupNo = groupno, Age = age };

Console.WriteLine($"Ad,soyad - {student.Fullname} , Qrup nomresi - {student.GroupNo} , Yaş - {student.Age}");

