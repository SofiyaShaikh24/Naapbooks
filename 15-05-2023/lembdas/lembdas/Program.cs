using System;
using System.Collections.Generic;

var students = new List<Student>
    {
        new("Sofiya", "Shaikh", 10 , true),
        new(string.Empty, string.Empty, 10 , true),
        new("abc", "xyz", 10 , false),
        new("mno", "pqr", 10 , false)
    };

var resultlist = PassExam(students);
var PassedExam = string.Join(", ", resultlist);
Console.WriteLine(PassedExam);

List<Student> PassExam(List<Student> Students)
{
    var result = new List<Student>();
    foreach (var student in students)
    {
        if (student.pass)
        {
            result.Add(student);
        }
    }
    return result;
}
    record Student(string fname, string lname, int std, bool pass);
