using System;

struct Person {
    public string name;
    public string surname;
    public int age;
    public char gender;
}

class HelloWorld {
    static void Main(String[] args) {
        Console.WriteLine("Hello World");

        /***type casting***/
        typeCasting();

        /***switch statement***/
        condition();

        /***array manipulation***/
        arrayClass();

        /***value swapping***/
        swap();

        /***value swapping***/
        stringManipulation();

        /***struct ***/
        structBook();

        /***enumaration ***/
        enumaration();

        Console.ReadKey();
    }

    static void typeCasting() {
        double rand = 11.68;
        int rounded = (int)rand;

        Console.WriteLine("11.68 to int value: {0}", rounded);
    }

    static void condition() {
         /***SWITCH STATEMENT***/
         Console.WriteLine("SWITCH STATEMENT");
        char letter = 'M';

        switch (letter) {
            case 'M':
                Console.WriteLine("It is an M");
                break;
            default:
                Console.WriteLine("Unknown character: ");
                break;
        }
    }

    static void swap(){
        int x = 9, y = 6, temp = 0;
        Console.WriteLine("Before SWAP: x = 9, y = 6, temp = 0");
        temp = x;
        x = y;
        y = temp;

        Console.WriteLine("After SWAP: x = {0}, y = {1}, temp = {2}",x, y, temp);
    }

    static void arrayClass() {
        Console.WriteLine("ARRAY ARRAYS");
                int [,] intArray = new int[4,5] 
            {{27, 25, 24, 21, 28},
            {33, 36, 35, 31, 38},
            {44, 45, 41, 42, 47},
            {57, 55, 54, 53, 59}
            };

        int inner, outer;

        Console.WriteLine("number of elements: Array.LongLength = {0}", intArray.LongLength);
        Console.WriteLine("number of dimensions: Array.Rank = {0}", intArray.Rank);
        
        for (outer = 0; outer < 4; outer++) {

            for (inner = 0; inner < 5; inner++) {
                Console.Write("{0} ", intArray[outer, inner]);
            }
            Console.WriteLine("");
        }
    }

    static void stringManipulation() {
        /*character array to string */
        Console.WriteLine("Char array { 'M', 'a', 'n', 'i','p' } to string");
        char [] arrayCharacter = { 'M', 'a', 'n', 'i','p' };
        string word = new string(arrayCharacter);
        Console.WriteLine("string(arrayCharacter): {0}", word);

        /*join array element into a sentence */
        string [] messageArray = {"I", "am", "going", "to", "school."};
        Console.WriteLine("join array {'I', 'am', 'going', 'to', 'school'} to string.");
        String message = String.Join(" ", messageArray);
        Console.WriteLine("String.Join(' ', array): {0}", message);
    }

    static void structBook() {
        Person student;
        Person lecturer;

        student.name = "Micheal";
        student.surname = "Jackson";
        student.age = 19;
        student.gender = 'M';

        lecturer.name = "Sisanda";
        lecturer.surname = "Monsta";
        lecturer.age = 25;
        lecturer.gender = 'F';

        Console.WriteLine("Fullname: {0} {1}\nAge: {2}, Gender: {3}", student.name, student.surname,
           student.age, student.gender); 
        Console.WriteLine("Fullname: {0} {1}\nAge: {2}, Gender: {3}", lecturer.name, lecturer.surname,
           lecturer.age, lecturer.gender);
    }

    enum Months {
        JANUARY, FEBRUARY, MARCH, APRIL, MAY, JUNE,
            JULY, AUGUST, SEPTEMBER, OCTOBER, NOVEMBER, DECEMBER
    };

    static void enumaration() {
        Console.WriteLine("Months.JANUARY.ToString(): {0}", Months.JANUARY.ToString());
        Console.WriteLine("(int)Months.JUNE: {0}", (int)Months.JUNE);
        Console.WriteLine("(int)Months.DECEMBER: {0}", (int)Months.DECEMBER);
        Console.WriteLine("Months.JANUARY: {0}", Months.JANUARY);
    }
}

public class student {
    
}