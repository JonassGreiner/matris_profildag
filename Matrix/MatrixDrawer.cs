using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    partial class Program
    {
        public static void Draw2x2Matrix(float m00, float m01, float m10, float m11)
        {
            const int VALUE_LENGTH = 4;
            const int SPACER = 2;
            const int N = VALUE_LENGTH * 2 + SPACER + 1;

            const string FORMAT = "{0:0.##}";

            int cursorX = Console.CursorLeft;
            int cursorY = Console.CursorTop;

            Console.Write("┌");

            Console.SetCursorPosition(cursorX + N, cursorY++);
            Console.Write("┐");

            Console.SetCursorPosition(cursorX, cursorY);
            Console.Write("│");

            Console.Write(string.Format("{0,-4}  ", string.Format(FORMAT, m00)));
            Console.Write(string.Format("{0,4}", string.Format(FORMAT, m01)));

            Console.SetCursorPosition(cursorX + N, cursorY++);
            Console.Write("│");

            Console.SetCursorPosition(cursorX, cursorY);
            Console.Write("│");

            Console.SetCursorPosition(cursorX + N, cursorY++);
            Console.Write("│");

            Console.SetCursorPosition(cursorX, cursorY++);
            Console.Write("│");

            Console.Write(string.Format("{0,-4}  ", string.Format(FORMAT, m10)));
            Console.Write(string.Format("{0,4}", string.Format(FORMAT, m11)));
            Console.Write("│");

            Console.SetCursorPosition(cursorX, cursorY);
            Console.Write("└");

            Console.SetCursorPosition(cursorX + N, cursorY);
            Console.Write("┘");
        }

        public static void Draw3x3Matrix(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22)
        {

            const string FORMAT = "{0:0.##}";


            Console.Write(string.Format("{0,-4}  ", string.Format(FORMAT, m00)));
            Console.Write(string.Format("{0,4}", string.Format(FORMAT, m01)));
            Console.Write(string.Format("{0,12}", string.Format(FORMAT, m02)));

            Console.WriteLine();
            Console.WriteLine();


            Console.Write(string.Format("{0,-4}  ", string.Format(FORMAT, m10)));
            Console.Write(string.Format("{0,4}", string.Format(FORMAT, m11)));
            Console.Write(string.Format("{0,12}", string.Format(FORMAT, m12)));

            Console.WriteLine();
            Console.WriteLine();

            Console.Write(string.Format("{0,-4}  ", string.Format(FORMAT, m20)));
            Console.Write(string.Format("{0,4}", string.Format(FORMAT, m21)));
            Console.Write(string.Format("{0,12}", string.Format(FORMAT, m22)));
        }




        public static void Draw2x2Matrix(float[,] matrix)
        {
            Draw2x2Matrix(matrix[0, 0], matrix[0, 1], matrix[1, 0], matrix[1, 1]);
        }

        public static void Draw3x3ResultMatrix(float[,] matrix)
        {
            Draw3x3Matrix(matrix[0, 0], matrix[0, 1], matrix[0, 2],
                matrix[1, 0], matrix[1, 1], matrix[1, 2],
                matrix[2, 0], matrix[2, 1], matrix[2, 2]);
        }
    }
}
