**Add-migration,
update-database,
then project will be run with data**

===========================
Name : Rukon Uddin
CellPhone: 019352043521
Email: rukon2280@gmail.com

Problem 1: Normalize the Register up to 3rd Normal Form (3NF)
a. Normalize the Register
Given the register:
Doctor	Contact Number	Service Points	Department
Dr. Lissa Mwenda	+260766219936	Antenatal Care, Family Planning, Postnatal Care	Gynecology
Dr. Yvonne Sishuwa	+260766219937	Family Planning, Postnatal Care	Pediatrics
Dr. Machalo Mbale	+260766219938	Antenatal Care	Radiology and Imaging
Step 1: 1NF (First Normal Form)
Doctor	Contact Number	Service Point	Department
Dr. Lissa Mwenda	+260766219936	Antenatal Care	Gynecology
Dr. Lissa Mwenda	+260766219936	Family Planning	Gynecology
Dr. Lissa Mwenda	+260766219936	Postnatal Care	Gynecology
Dr. Yvonne Sishuwa	+260766219937	Family Planning	Pediatrics
Dr. Yvonne Sishuwa	+260766219937	Postnatal Care	Pediatrics
Dr. Machalo Mbale	+260766219938	Antenatal Care	Radiology and Imaging
Step 2: 2NF (Second Normal Form)
Dortors table
Doctor ID	Doctor Name	Contact Number	Department
1	Dr. Lissa Mwenda	+260766219936	Gynecology
2	Dr. Yvonne Sishuwa	+260766219937	Pediatrics
3	Dr. Machalo Mbale	+260766219938	Radiology and Imaging
ServicePoints Table:
Doctor ID	Service Point
1	Antenatal Care
1	Family Planning
1	Postnatal Care
2	Family Planning
2	Postnatal Care
3	Antenatal Care
Step 3: 3NF (Third Normal Form)
Entities:
•	Doctor
•	ServicePoint
Relationships:
•	A Doctor can have multiple ServicePoints.
•	A ServicePoint is associated with one Doctor.
Doctor (DoctorID, DoctorName, ContactNumber, Department) | |------<has>------| | ServicePoint (DoctorID, ServicePoin

Problem 2: Trace the Value of n in Every Iteration
Trace of n
Int n=30
For(int i=0; i<=5; i++)
{
 n+=i
}
Print (n)

i	n (Before Addition)	n (After Addition)
0	30	30
1	30	31
2	31	33
3	33	36
4	36	40
5	40	45
Final value of n printed: 45.
________________________________________
Problem 4: Method Overloading and Method Overriding in C#
a.	Method Overloading
class Example
{
    public void Display(int a)
    {
        Console.WriteLine("Displaying integer: " + a);
    }

    public void Display(string a)
    {
        Console.WriteLine("Displaying string: " + a);
    }
}
Method Overriding:
class BaseClass
{
    public virtual void Show()
    {
        Console.WriteLine("Base class show method");
    }
}

class DerivedClass : BaseClass
{
    public override void Show()
    {
        Console.WriteLine("Derived class show method");
    }
}
Problem 5: Translate UML Class Diagram into C# Code
public class Clinician
{
    public string Name { get; set; }
    public string HospitalName { get; set; }

    public bool Login(string username, string password)
    {
        // Implementation
        return true;
    }

    private bool IsSessionExists(string username)
    {
        // Implementation
        return false;
    }
}

public class Doctor : Clinician
{
    public string PracticeNumber { get; set; }

    public void CreatePrescription(int patientNumber)
    {
        // Implementation
    }
}

public class Pharmacist : Clinician
{
    public string PharmacistNumber { get; set; }

    public void DispenseMedications(int prescriptionNumber)
    {
        // Implementation
    }
}

Problem 6: Translate UML Activity Diagram into C# Code
using System;

class Program
{
    static void Main()
    {
        int n1, n2, n3;
        Console.WriteLine("Enter three integer values:");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        n3 = int.Parse(Console.ReadLine());

        int min;
        if (n1 < n2)
        {
            min = n1;
        }
        else
        {
            min = n2;
        }

        if (n3 < min)
        {
            min = n3;
        }

        Console.WriteLine("The minimum value is: " + min);
    }
}

