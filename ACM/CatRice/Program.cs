using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatRice
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = 9;

            int[] F = new int[lines];
            int[] J = new int[lines];

            while (lines >= 0)
            {
                lines--;

            }
        }

        static public class CatRice
        {

            static int Change(int[] F, int[] J, int N)
            {
                int M = 0;
                foreach (int f in F) M += f;

                int result_J = 0;

                // percent
                for (int a = 1; a <=100; a++)
                {
                    int totoal_J = 0;
                    // room
                    for (int i = 0; i < N; i++)
                    {
                        M -= F[i] * a / 100;

                        while (M < 0) break;

                        totoal_J += J[i] * a / 100;
                    }

                    result_J = Math.Max(totoal_J, result_J);
                }

                return result_J;
            }
        }
    }
}
