using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixVerifyer;

namespace Matrix
{
    partial class Program
    {
        static void Main(string[] args)
        {

            #region Matrix[2x2]
            Matrix22 MatrixA = new Matrix22();
            
            MatrixA.elements[0, 0] = 1;
            MatrixA.elements[0, 1] = 2;
            MatrixA.elements[1, 0] = 1;
            MatrixA.elements[1, 1] = 3;

            Matrix22 MatrixB = new Matrix22();

            MatrixB.elements[0, 0] = 1;
            MatrixB.elements[0, 1] = 2;
            MatrixB.elements[1, 0] = 1;
            MatrixB.elements[1, 1] = 3;

            MatrixA.range = 1; MatrixB.range = 1;
            #endregion

            #region Matrix[3x3]
            Matrix22 MatrixA3 = new Matrix22();

            MatrixA3.elements3[0, 0] = 1;
            MatrixA3.elements3[0, 1] = 2;
            MatrixA3.elements3[0, 2] = 3;
            MatrixA3.elements3[1, 0] = 1;
            MatrixA3.elements3[1, 1] = 2;
            MatrixA3.elements3[1, 2] = 3;
            MatrixA3.elements3[2, 0] = 1;
            MatrixA3.elements3[2, 1] = 2;
            MatrixA3.elements3[2, 2] = 3;

            Matrix22 MatrixB3 = new Matrix22();

            MatrixB3.elements3[0, 0] = 1;
            MatrixB3.elements3[0, 1] = 2;
            MatrixB3.elements3[0, 2] = 3;
            MatrixB3.elements3[1, 0] = 1;
            MatrixB3.elements3[1, 1] = 2;
            MatrixB3.elements3[1, 2] = 3;
            MatrixB3.elements3[2, 0] = 1;
            MatrixB3.elements3[2, 1] = 2;
            MatrixB3.elements3[2, 2] = 3;

            MatrixA3.range = 2; MatrixB3.range = 2;
            #endregion

            Console.WriteLine("1: 2x2"); Console.WriteLine("2: 3x3");
            int range = Convert.ToInt32(Console.ReadLine());
            
            Console.Clear();
            if (range == 1)
            {
                //Addition
                Console.WriteLine("Addition;");
                Matrix22 MatrixAddition = MatrixA.Add(MatrixB);
                Draw2x2Matrix(MatrixAddition.elements);
                Console.WriteLine();

                //Multiplication

                Console.WriteLine("Multiplication;");
                Matrix22 MatrixMultiplication = MatrixA.Multiply(MatrixB);
                Draw2x2Matrix(MatrixMultiplication.elements);
                Console.WriteLine();

                //RotationMatrix
                Console.WriteLine("RotationMatrix;");
                Matrix22 MatrixRadiate = MatrixA.Radiate();
                Draw2x2Matrix(MatrixRadiate.elements);
                Console.WriteLine();
            }
            if (range == 2)
            {
                //Addition
                Console.WriteLine("Addition;");
                Matrix22 MatrixAddition = MatrixA3.Add(MatrixB3);
                Draw3x3ResultMatrix(MatrixAddition.elements3);
                Console.WriteLine();

                //Multiplication

                Console.WriteLine("Multiplication;");
                Matrix22 MatrixMultiplication = MatrixA3.Multiply(MatrixB3);
                Draw3x3ResultMatrix(MatrixMultiplication.elements3);
                Console.WriteLine();

                //RotationMatrix
                Console.WriteLine("RotationMatrix;");
                Matrix22 MatrixRadiate = MatrixA3.Radiate();
                Draw3x3ResultMatrix(MatrixRadiate.elements3);
                Console.WriteLine();
            }


            #region Instruktioner
            /*
             * Där finns tester tillgängliga genom att skriva
             * MatrixChecker.CheckAddition
             * MatrixChecker.CheckMultiplication
             * MatrixChecker.CheckRotationMatrix
             * 
             * Observera att testerna inte är noga testade.
             * 
             * De tar emot argument enligt följande standard:
             * CheckAddition tar emot alla Matris-värden 00, 01, 10, 11 för matris A
             * och alla Matris-värden 00, 01, 10, 11 för matris B, och den sista är
             * då det uträknade resultatet av A + B, som då är en matris 00, 01, 10, 11
             * 
             * CheckMultiplication liknar CheckAddition, den tar emot tre matriser,
             * A, B och sedan resultatet av A * B. Sen kommer den att jämföra och se
             * ifall matrisen har blivit rätt
             * 
             * CheckRotationMatrix tar emot antalet radianer du roterat en matris av,
             * och sedan en rotationsmatris som du har skapat. Den jämför sedan värden
             * för att se ifall matriserna stämmer överens.
             */

            /*
             * Där finns ett inbyggt verktyg för att rita ut matriser i två format.
             * Den första tar emot alla matrisvärden, 00, 01, 10, 11 och den andra
             * tar emot en float[,] (en float 2D-array) och skriver sedan ut matrisen
             * formaterat, och endast med 2 decimaler.
             */

            // De fyra första siffrorna = Matris A, de nästa fyra siffrorna = Matris B, de sista fyra siffrorna = resultatet av A + B
            // Exempel: MatrixChecker.CheckAddition(1, 2, 3, 4, 1, 2, 3, 4, 2, 4, 6, 8);

            // De fyra första siffrorna = Matris A, de nästa fyra siffrorna = Matris B, de sista fyra siffrorna = resultatet av A * B
            // Exempel: MatrixChecker.CheckMultiplication(1, 2, 3, 4, 1, 2, 3, 4, 7, 10, 15, 22);


            // Byt ut detta anropet med dina matrisvärden, så kommer programmet att rita ut dem istället :)
            #endregion



            Console.ReadKey();
        }
    }
}
