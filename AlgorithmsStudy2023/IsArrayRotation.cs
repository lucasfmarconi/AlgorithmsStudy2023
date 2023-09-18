using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsStudy2023;
public static class IsArrayRotation
{
    //BIG O - O(n) or O(2n)
    public static bool IsArrayRotationSolution(int[] arrayA, int[] arrayB)
    {
        return IsRotation(arrayA, arrayB) || IsRotation(arrayB, arrayA);
    }

    private static bool IsRotation(int[] arrayA, int[] arrayB)
    {
        if (arrayA.Length != arrayB.Length)
            return false;

        var pointerArrayB = 0;

        while (pointerArrayB < arrayB.Length)
        {
            var valueInA = arrayA[0];
            var valueInB = arrayB[pointerArrayB];
            if (valueInA != valueInB)
            {
                pointerArrayB++;
                continue;
            }

            break;
        }

        //var reversedArrayB = new int[arrayB.Length];
        var auxList = new List<int>();
        auxList.AddRange(arrayB[pointerArrayB..]);
        auxList.AddRange(arrayB[..pointerArrayB]);
        var reversedArrayB = auxList.ToArray();

        for (var i = 0; i < arrayA.Length; i++)
        {
            if (arrayA[i] != reversedArrayB[i])
                return false;
        }

        return true;
    }
}
