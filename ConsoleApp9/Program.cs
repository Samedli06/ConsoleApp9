
using ConsoleApp9;

static void Maxx(int[] ints) {
    int M = ints[0];

    for (int i = 0; i < ints.Length; i++)
    {
        if (ints[i] > M)
        {
            M = ints[i];
        }
    }

    Console.WriteLine(M);
}

void Minn(int[] ints)
{
    int M = ints[0];

    for (int i = 0; i < ints.Length; i++)
    {
        if (ints[i] < M)
        {
            M = ints[i];
        }
    }

    Console.WriteLine(M);
}

void Summ(int[] ints)
{
    int M = ints[0];
    int sum = 0;

    for (int i = 0; i < ints.Length; i++)
    {
        sum += ints[i];
    }

    Console.WriteLine(sum);
}

//int[] Sortt(int[] ints) // 1,4,8,13,0,134 
//{
//    // ew arr sortd_list  
//    int[] list = {};
//    int M = ints[0];//4

//    for (int i = 0; i < ints.Length; i++)
//    {
//        if (ints[i] < M)
//        {
//            M = ints[i];
//        }
//        list[0]=(M); // 

//    }

//    return list;
//}

//Functions myarray = new Functions();

//myarray.Add(10);
//myarray.Add(90);
//myarray.Add(25);
//myarray.Add(123);
//myarray.Add(2);
//myarray.Insert(2, 25);
//myarray.Remove(10);

//for (int i = 0; i < myarray.count; i++)
//{
//    Console.Write(myarray.items[i] + " ");
//}

//Console.WriteLine("\n");

//myarray.RemoveAll(x => x == 25);

//for (int i = 0; i < myarray.count; i++)
//{
//    Console.Write(myarray.items[i] + " ");
//

int[] array = { 1, 3, 2, 45, 4, 768, 231, 12 };

Sortt sortt = new Sortt(array);

int[] newArray = sortt.Sort(array);

for (int i = 0; i < newArray.Length-1; i++)
{
    Console.WriteLine(newArray[i]);
}





//int[] arrayy = { 1, 4, 3, 94, 12, 31321 };

//var x = Sortt(arrayy);

//foreach (var item in x)
//{
//    Console.WriteLine(item);
//}

//Maxx(arrayy);
//Minn(arrayy);
//Summ(arrayy);
