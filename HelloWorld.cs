using System;

class HelloWorld {
    static void Main(String[] args) {
        Console.WriteLine("Hello World");

        /***TYPE CASTING***/
        double rand = 11.68;
        int rounded = (int)rand;

        Console.WriteLine("TYPE CASTING DOUBLE TO INT");
        Console.WriteLine("11.68 to int value: {0}", rounded);

        /***USER INPUT***/
        // int num;
        // num = Convert.ToInt32(Console.ReadLine());
        
        /***SWITCH STATEMENT***/
        char letter = 'M';

        switch (letter) {
            case 'M':
                Console.WriteLine("It is an M");
                break;
            default:
                Console.WriteLine("Unknown character: ");
                break;
        }



        int x = 9, y = 6, temp = 0;
        Console.WriteLine("Before SWAP: x = 9, y = 6, temp = 0");
        temp = x;
        x = y;
        y = temp;

        // Console.WriteLine("After SWAP: x = {0}", temp);
        Console.WriteLine("After SWAP: x = {0}, y = {1}, temp = {2}",x, y, temp);

        int [,] intArray = new int[4,5] 
            {{27, 25, 24, 21, 28},
            {33, 36, 35, 31, 38},
            {44, 45, 41, 42, 47},
            {57, 55, 54, 53, 59}
            };

        int inner, outer;

        for (outer = 0; outer < 4; outer++) {

            for (inner = 0; inner < 5; inner++) {
                Console.Write("{0} ", intArray[outer, inner]);
            }
            Console.WriteLine("\n");
        }
        Console.ReadKey();
    }
}