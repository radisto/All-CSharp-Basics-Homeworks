using System;

class EmployeeData
{
    static void Main()
    {
        DataInfo Employee1 = new DataInfo();
        Employee1.firstName = "John";
        Employee1.lastName = "Smith";
        Employee1.age = 34;
        Employee1.gender = 'm';
        Employee1.personalID = 8004116507;
        Employee1.uniqueNumber = 27560001;
        DataPrint(Employee1);
        DataInfo Employee2 = new DataInfo();
        Employee2.firstName = "Jessica";
        Employee2.lastName = "Parker";
        Employee2.age = 31;
        Employee2.gender = 'f';
        Employee2.personalID = 8207196419;
        Employee2.uniqueNumber = 27560002;
        DataPrint(Employee2);
    }

    static void DataPrint(DataInfo info)
    {
        Console.WriteLine(info.firstName);
        Console.WriteLine(info.lastName);
        Console.WriteLine(info.age);
        Console.WriteLine(info.gender);
        Console.WriteLine(info.personalID);
        Console.WriteLine(info.uniqueNumber);
        Console.WriteLine();
    }
}

public class DataInfo
{
    public string firstName;
    public string lastName;
    public byte age;
    public char gender;
    public ulong personalID;
    public uint uniqueNumber;
}
