﻿// Найти максимум из 9 чисел

int Max(int arg1, int arg2, int arg3)
{
    int max = arg1;
    if(arg2 > max) max = arg2;
    if(arg3 > max) max = arg3;
    return max;
}
//               0   1   2   3   4   5   6   7   8
int [] array = {11, 21, 31, 41, 51, 62, 17, 18, 19};
// array[0] = 12;
// Console.WriteLine(array[0]);


int max = Max(Max(array[0], array[1], array[2]), 
    Max(array[3] , array[4], array[5]), 
    Max(array[6] , array[7], array[8]));
Console.WriteLine(max);
