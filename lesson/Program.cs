namespace lesson
{
    public class Program
    {
        /// <summary>
        /// The main entrypoint of your application.
        /// </summary>
        /// <param name="args">The arguments passed to the program</param>
        public static void Main(string[] args)
        {
            /*// Write some code here...
            //int n = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Il perimetro del quadrato è " + n * 4);
            //Console.WriteLine("L'area del quadrato è " + n * n);
            Console.Write("Non va a capo!");
            Console.WriteLine("Ciao mondo!");
            Console.WriteLine("Inserisci un numero naturale.");
            int n = Convert.ToInt32(Console.ReadLine());

            //tipo di dato booleano: rispetta l'algebra di boole (vero / falso)
            //bool b = true; O
            bool b = false;
            Console.WriteLine("Tipo di dato 'bool': ");
            Console.WriteLine($"- ammette {true} oppure {false}");
            Console.WriteLine($"- non ammette nessun altro valore");

            Console.WriteLine();
            //tipo di dato "numero intero". Non ammette cifre dietro la virgola. Permette le operazioni di resto e quoto  
            int i = 0;
            Console.WriteLine("Tipo di dato 'int':");
            Console.WriteLine("-rappresenta un numero intero");
            Console.WriteLine($"- valore minimo: {int.MinValue}");
            Console.WriteLine($"- valore massimo: {int.MaxValue}");

            Console.WriteLine();
            //tipo di dato "numero intero corto". Come int, ma ha un intervallo di valore stretto (circa la metà di int)
            short sh = 0;

            Console.WriteLine("Tipo di dato 'short':");
            Console.WriteLine("-rappresenta un numero intero");
            Console.WriteLine($"- valore minimo: {short.MinValue}");
            Console.WriteLine($"- valore massimo: {short.MaxValue}");

            Console.WriteLine();
            //tipo di dato "numero intero lungo". Come int, ma ha un intervallo di valori più ampio (circa il doppio delle cifre di int)
            long l = 0;

            Console.WriteLine("Tipo di dato 'long':");
            Console.WriteLine("-rappresenta un numero intero");
            Console.WriteLine($"- valore minimo: {long.MinValue}");
            Console.WriteLine($"- valore massimo: {long.MaxValue}");

            Console.WriteLine();
            //tipo di dato "numero con virgola". Permette cifre dietro la virgola, ad una determinata PRECISIONE (precisione singola)
            float f = 0;

            Console.WriteLine("Tipo di dato 'float':");
            Console.WriteLine("-rappresenta un numero con la virgola");
            Console.WriteLine($"- valore minimo: {float.MinValue}");
            Console.WriteLine($"- valore massimo: {float.MaxValue}");
            Console.WriteLine($"- Infinito: {float.PositiveInfinity}");
            Console.WriteLine($"- Infinito: {float.NegativeInfinity}");

            Console.WriteLine();
            //tipo di dato "numero con virgola, precisione doppia". Come float, ma ammette una precisione maggiore
            double d = 0;

            Console.WriteLine("Tipo di dato 'double':");
            Console.WriteLine("-rappresenta un numero con la virgola");
            Console.WriteLine($"- valore minimo: {double.MinValue}");
            Console.WriteLine($"- valore massimo: {double.MaxValue}");
            Console.WriteLine($"- Infinito: {double.PositiveInfinity}");
            Console.WriteLine($"- Infinito: {double.NegativeInfinity}");

            Console.WriteLine();
            //tipo di dato decimal, ovvero "numero decimale con virgola". Come float, ma ha una precisione molto maggiore. Occupa molta memoria.
            decimal dc = 0;

            Console.WriteLine("Tipo di dato 'decimal':");
            Console.WriteLine("-rappresenta un numero con la virgola");
            Console.WriteLine($"- valore minimo: {decimal.MinValue}");
            Console.WriteLine($"- valore massimo: {decimal.MaxValue}");

            Console.WriteLine();
            //tipo di dato "byte". Numero intero fra 0 e 255.
            byte bt = 0;

            Console.WriteLine("Tipo di dato 'byte':");
            Console.WriteLine("-rappresenta un numero che sta in un byte");
            Console.WriteLine($"- valore minimo: {byte.MinValue}");
            Console.WriteLine($"- valore massimo: {byte.MaxValue}");

            Console.WriteLine();
            //tipo di dato "carattere". Rappresenta un singolo carattere UNICODE.
            char c = '\0';

            Console.WriteLine("Tipo di dato 'char':");
            Console.WriteLine("-rappresenta un carattere");
            Console.WriteLine($"- valore minimo: {char.MinValue}");
            Console.WriteLine($"- valore massimo: {char.MaxValue}"); //65535 = 2 byte - 1 

            Console.WriteLine();
            //tipo di dato "stringa". Rappresenta una serie di caratteri, terminata da un carattere terminatore ('\0', in  C# è astratto)
            string s = "";

            Console.WriteLine("Tipo di dato 'stringa':");
            Console.WriteLine("-rappresenta una stringa");
            Console.WriteLine($"- String.Empty: {string.Empty}"); // == "";

            Console.WriteLine("________");
            Console.WriteLine();

            Console.WriteLine(@"Il metodo .Join permette di mettere insieme più stringhe in una sola,
            naturalmente separando con un carattere separatore");

            string result = string.Join('_', "ciaone", "proprio");
            Console.WriteLine($"string.Join('_', 'ciaone', 'proprio') -> {result}");

            if (n < 0)
            {
                Console.WriteLine($"{n} non è un numero naturale");
            }
            else
            {
                Console.WriteLine($"{n} è un numero naturale");
            }*/
            Console.WriteLine();
            Console.WriteLine("Ora gli esercizi");
            Console.WriteLine("Esercizio1:");
            Esercizio1();
            Console.WriteLine("Esercizio2:");
            Esercizio2();
            Console.WriteLine("Esercizio3:");
            Esercizio3();
            Console.WriteLine("Esercizio4:");
            Esercizio4();
        }

        // battendo tre / creo i commenti di documentazione
        /// <summary>
        /// Visualizza 100 numeri pari, partendo dal numero 2
        /// </summary>
        /// Calcola il fattoriale di un numero n in ingresso.
        /// Il fattoriale di un numero si indica con n!
        /// 0!=1, 1! =1, 2! =2+1, 3! =3*2*1, e così via...
        /// Es. 3 converto in binario un n in ingresso
        /// Dato n in input un numero n intero positivo stampa video il termine n-esimo della successione di Fibonacci
        /// fibonacci=(n+1)+(n)
        private static void Esercizio1()
        {
            for (int i = 2; i <= 200; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i}");
                }
            }

        }
        private static void Esercizio2()
        {
            Console.WriteLine("Insert a positive number in input.");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = 1;

            if (n < 0)
            {
                Console.WriteLine("The number must be positive.");
            }
            else
            {

                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }

                Console.WriteLine($"{result}");

            }
        }
        private static void Esercizio3()
        {
            Console.WriteLine("Inserisci un numero in binario:");
            string line = Console.ReadLine()!;
            /*int a = 0;

            if (a==0)
            {
            
                int valoreDecimale = Convert.ToInt32(line, 2);//NON E' PIACIUTO AL PROF PERCHE? SFRUTTA LA FUNZIONE
                Console.WriteLine($"Il numero in decimale è: {valoreDecimale}");
            }
            else
            {
                Console.WriteLine("Il numero inserito non è un numero binario valido.");
            }*/
            double result = 0;
            for (int i = 0; i < line.Length; i++)
            {
                int currentExpValue = Convert.ToInt32(line[i].ToString());
                result += currentExpValue * Math.Pow(2, line.Length - 1 - i);
            }
            Console.WriteLine($"{line} -> {result}");
        }

        private static void Esercizio4()
        {

            Console.WriteLine("Insert a positive number in input.");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("The number must be positive.");
            }
            else if (n < 2)
            {
                Console.WriteLine($"fibonacci({n}) -> {n}");
            }
            else
            {
                int first = 0;
                int second = 1;

                for (int i = 2; i <= n; i++)
                {
                    int temp = first + second;
                    first = second;
                    second = temp;
                }
                Console.WriteLine($"Il fibonacci del num. {n} è {second}.");
            }
        }
    }
}
