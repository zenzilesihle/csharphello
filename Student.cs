using System;

public class Student: User {
    private string studentNumber;
    
    public Student() {
        Console.WriteLine("Student object created!");
    }

    public string getStudentNumber() {
        return studentNumber;
    }

    public void setStudentNumber(string sn) {
        studentNumber = sn;
    }
}