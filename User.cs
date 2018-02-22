using System;

public class User {
    private string name;
    private string surname;

    public User() {
        Console.WriteLine("User object Created");
    }

    public void setName(string n) {
        name = n;
    }

    public string getName() {
        return name;
    }

    public void setSurname(string sn) {
        surname = sn;
    }

    public string getSurname() {
        return surname;
    }





    ~User() {
        Console.WriteLine("Destructor called.");
    }
}