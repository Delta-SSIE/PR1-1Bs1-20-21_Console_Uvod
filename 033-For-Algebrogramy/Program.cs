using System;

namespace _033_For_Algebrogramy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Při řešení algebrogramu dosazujeme do zadání místo písmen
            //číslice. Obvykle jsou povoleny všechny číslice 0-9 s tím, že 0
            //nesmí být na začátku žádné číslice a různá písmena znamenají 
            //různé číslice.

            //Řešte algebrogram A·C·AC = CCC

            for (int A = 1; A < 10; A++)
            {
                for (int C = 1; C < 10; C++)
                {
                    if (A == C)
                        continue; // přejdi na další iteraci

                    if (A * C * (A * 10 + C) == C * 100 + C * 10 + C )
                    {
                        Console.WriteLine($"A={A}, C={C}");
                        Console.WriteLine($"{A}.{C}.{A}{C} = {C}{C}{C}");
                    }
                }
            }
            Console.WriteLine();

            //Řešte algebrogram
            //  KC +  I = OK
            //   +    +    +
            //   E +  E = KM
            //  ------------
            //  OL + KO = LI

            int i = 0;
            for (int K = 1; K < 10; K++)
            {
                for (int C = 0; C < 10; C++)
                {
                    if (C == K)
                        continue;
                    for (int I = 1; I < 10; I++)
                    {
                        if (I == K || I == C)
                            continue;
                        for (int O = 1; O < 10; O++)
                        {
                            if (O == K || O == C || O == I)
                                continue;
                            for (int E = 1; E < 10; E++)
                            {
                                if (E == K || E == C || E == I || E == O)
                                    continue;
                                for (int M = 0; M < 10; M++)
                                {
                                    if (M == K || M == C || M == I || M == O || M == E)
                                        continue;
                                    for (int L = 1; L < 10; L++)
                                    {
                                        if (L == K || L == C || L == I || L == O || L == E || L == M)
                                            continue;

                                        i++;
                                        if (
                                            K * 10 + C + I == O * 10 + K
                                            && E + E == K * 10 + M
                                            && O * 10 + L + K * 10 + O == L * 10 + I
                                            && K * 10 + C + E == O * 10 + L
                                            && I + E == K * 10 + O
                                            && O * 10 + K + K * 10 + M == L * 10 + I
                                        )
                                        {
                                            Console.WriteLine($"{K}{C} +  {I} = {O}{K}");
                                            Console.WriteLine(" +    +    +");
                                            Console.WriteLine($" {E} +  {E} = {K}{M}");
                                            Console.WriteLine("------------");
                                            Console.WriteLine($"{O}{L} + {K}{O} = {L}{I}");
                                            Console.WriteLine();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"Bylo testováno {i} kombinací.");
        }
    }
}
