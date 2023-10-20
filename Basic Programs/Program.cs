
using Basic_Programs;


EV ev = new();
ev.vehnum = 444;
ev.Brand = "XX";
ev.model = "AA";
ev.Disp();
Console.WriteLine(ev.setTypeForVeh());

PV pv = new();
pv.vehnum = 555;
pv.Brand = "XY";
pv.model = "AB";
pv.Disp();
Console.WriteLine(pv.setTypeForVeh());


/*
Console.WriteLine("1. TS 2. NTS 3.Student Details");

switch(Convert.ToInt32(Console.ReadLine()))
{
    case 1:
        TeachingStaff ts = new TeachingStaff();
        ts.StaffId = 111;
        ts.Name = "TS1";
        ts.Dept = "CS";
        ts.Specializations = "OS, DBMS, DS";
        ts.Sem =4;
        ts.DisplayStaffDetails();
        break;
    case 2:
        NonTeachingStaff nts = new NonTeachingStaff();
        nts.StaffId = 991;
        nts.Name = "NTS1";
        nts.Dept = "CS";
        nts.Responsibilities = "Att,Sal";
        nts.Experience = 4;
        nts.DisplayStaffDetails();
        nts.DisplayNTStaffDetails();
        
        break;

    case 3:
        StudentDetails student = new StudentDetails();
        student.StudName = "IND";
        student.City = "TRV";
        student.CID = 123;
        student.CName = "XYZ";
        student.DisplayStudentDetails();
        student.DisplayCollegeDetails();
        break;

}




/*StudentGrade grade = new();
grade.RollNo = 1000;
grade.StudName = "AAA";
grade.Mark1 = 89;
grade.Mark2 = 90;
grade.Mark3 = 91;
grade.City = "TVM";
grade.DisplayStudentDetails();
Console.WriteLine("Total " + grade.CalculateTotal());
Console.WriteLine("Average " + grade.CalculateAverage());
Console.WriteLine("Grade " + grade.CalculateGrade());*/

/*
Employee employee = new(111, "AA", "IT", 10000);
Console.WriteLine("Emp Id: {0} \nName : {1} \nDept : {2} \nBasic Pay : {3}" , employee.Eid, employee.Ename, employee.Dept, employee.Basicpay);
Console.WriteLine("Net Pay : {0} ",employee.CalculateSalary());
*/


/*StudentMarks marks = new();
marks.RollNo = 1000;
marks.StudName = "AAA";
marks.Mark1 = 89;
marks.Mark2 = 90;
marks.Mark3 = 91;
marks.City = "TVM";
marks.DisplayStudentDetails();
Console.WriteLine("Total " + marks.CalculateTotal());
Console.WriteLine("Average " + marks.CalculateAverage());*/