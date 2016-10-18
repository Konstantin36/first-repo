using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class ArrayModifier
{
    static void Main(string[] args)
    {
        var arr = Console.ReadLine().Split(' ')
            .Select(long.Parse).ToArray();
        while (true)
        {
            var cmd = Console.ReadLine().Split(' ');
            if (cmd[0] == "end")
                break;
            if (cmd[0] == "swap")
                Swap(arr, cmd);
            else if (cmd[0] == "multiply")
                Multiply(arr, cmd);
            else if (cmd[0] == "decrease")
                Decrease(arr);
        }
        Console.WriteLine(string.Join(", ",arr));
    }

    private static void Decrease(long[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i]--;
        }
    }

    private static void Multiply(long[] arr, string[] cmd)
    {
        int index1 = int.Parse(cmd[1]);
        int index2 = int.Parse(cmd[2]);
        arr[index1] = arr[index1] * arr[index2];
    }

    private static void Swap(long[] arr, string[] cmd)
    {
        int index1 = int.Parse(cmd[1]);
        int index2 = int.Parse(cmd[2]);
        var oldValue = arr[index1];
        arr[index1] = arr[index2];
        arr[index2] = oldValue;
    }
}

