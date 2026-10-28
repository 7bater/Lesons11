//using System;

//namespace Lessons11
//{
//    public static class MathExtensions
//    {
//        public static T Min<T>(T a, T b, T c) where T : IComparable<T>
//        {
//            T min = a;

//            if (b.CompareTo(min) < 0)
//            {
//                min = b;
//            }

//            if (c.CompareTo(min) < 0)
//            {
//                min = c;
//            }

//            return min;
//        }

//        public static T Max<T>(T a, T b, T c) where T : IComparable<T>
//        {
//            T max = a;

//            if (b.CompareTo(max) > 0)
//            {
//                max = b;
//            }

//            if (c.CompareTo(max) > 0)
//            {
//                max = c;
//            }

//            return max;
//        }
//    }
//}

//ex2
using System.Numerics;

namespace Lessons11
{
    public static class MathExtensions
    {
        public static T SumArray<T>(T[] array) where T : INumber<T>
        {
            T sum = T.Zero;

            foreach (var item in array)
            {
                sum += item;
            }

            return sum;
        }
    }
}