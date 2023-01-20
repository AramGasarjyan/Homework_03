//Ստեղծել ստրուկտուրա

//Որը իրեն կներկայացնի որպես կոորդինատներ և իր մեջ կպարունակի (x, y) արժեքները

// —  Հաշվել երկու կոորդինատների միջև հեռավորությունը



//d=√((x2 – x1)² + (y2 – y1)²)



using System;



Point point1 = new Point(1, 2);

Point point2 = new Point(3, 4);

Console.WriteLine(point1.Distance(point2));









//Ստեղծել ստրուկտուրա

//Որը կներկայացնի ապրանքը, իր մեջ կպարունակի, անվանում և արժեքը, հաշվել տրված ապրանքների ընդհանուր գումարը



Item banana = new Item("Banana", 10f);

Item apple = new Item("Apple", 5f);

Item oringe = new Item("Oringe", 7f);

Item grapefruit = new Item("Grapefruit", 6f);

Console.WriteLine(Item.Sum());







//Տրված է n,n տարրեր պարունակող երկչափ զանգված



// - Հաշվել, բոլոր տարրերի միջին թվաբանականը որոնք ընկած են մատրիցի հիմնական անկյունագծի տակը ներառյալ անկյունագիծը

// - Հաշվել, բոլոր կենտ տարրերի քանակը որոն ընկած են մատրիցի օժանդակ անկյունագծի վերևում ներառյալ անկյունագիծը



int n;

int.TryParse(Console.ReadLine(), out n);

Console.WriteLine();



int[,] matrix = new int[n, n];



Fillmatrix(ref matrix);

Printmatrix(matrix);



Console.WriteLine(Sum(matrix));

Console.WriteLine(OddNumbers(matrix));



int Sum(int[,] matrix)

{

    int sum = 0;



    for (int i = 0; i < matrix.GetLength(dimension: 0); i++)

    {

        for (int j = 0; j <= i; j++)

        {

            sum += matrix[i, j];

        }

    }

    return sum;

}



int OddNumbers(int[,] matrix)

{

    int count = 0;

    int horizontal = matrix.GetLength(dimension: 1);



    for (int i = 0; i < matrix.GetLength(dimension: 0); i++)

    {

        horizontal--;

        for (int j = 0; j <= horizontal; j++)

        {

            if (matrix[i, j] % 2 != 0)

            {

                count++;

            }



        }

    }

    return count;

}



void Fillmatrix(ref int[,] matrix)

{

    Random random = new Random();



    for (int i = 0; i < matrix.GetLength(dimension: 0); i++)

    {

        for (int j = 0; j < matrix.GetLength(dimension: 1); j++)

        {

            matrix[i, j] = random.Next(1, 9);

        }

    }

}



void Printmatrix(int[,] matrix)

{

    for (int i = 0; i < matrix.GetLength(dimension: 0); i++)

    {

        for (int j = 0; j < matrix.GetLength(dimension: 1); j++)

        {

            Console.Write(matrix[i, j] + "\t");

        }

        Console.WriteLine();

    }

}







struct Point

{

    double x;

    double y;



    public Point(double x, double y)

    {

        this.x = x;

        this.y = y;

    }



    public double Distance(Point point)

    {

        return Math.Sqrt(Math.Pow((point.x - this.x), 2) + Math.Pow((point.y - this.y), 2));

    }



}





struct Item

{

    string name;

    float amount;

    private static Item[] instances = new Item[0];

    private static int count;



    public Item(string name, float amount)

    {

        this.name = name;

        this.amount = amount;

        Array.Resize(ref instances, ++count);

        instances[count - 1] = this;

    }



    public static float Sum()

    {

        float sum = 0;

        for (int i = 0; i < instances.Length; i++)

        {

            sum += instances[i].amount;

        }

        return sum;

    }

}


