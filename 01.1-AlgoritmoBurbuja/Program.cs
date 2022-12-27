namespace _01._1_AlgoritmoBurbuja;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ALGORITMO DE LA BURBUJA");

        // Inicializar el arreglo con valores aleatorios
        Random random = new Random();
        int[] A = new int[10];
        for (int i = 0; i < A.Length; i++)
        {
            A[i] = random.Next(1, 101);
        }

        // Imprimir el arreglo desordenado
        Console.Write("Arreglo Desordenado: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write(A[i] + " ");
        }

        // Inicio de proceso de ordenamiento
        Console.WriteLine("\n\nComienza burbuja".PadRight(37) + "Cambio".PadRight(10) + "Pasada");
        DateTime inicio = DateTime.Now;
        burbuja(A);
        TimeSpan tiempoTranscurrido = DateTime.Now.Subtract(inicio);

        // Imprimir el arreglo ordenado
        Console.Write("\nArreglo Ordenado por Burbuja: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write(A[i] + " ");
        }
        Console.WriteLine($"\nTiempo de ejecución de Función: {tiempoTranscurrido.TotalMilliseconds} ms");
    }

    static void burbuja(int[] A)
    {
        int aux;
        String ArregloString = ("");
        for (int i = 0; i < A.Length - 1; i++)
        {
            for (int j = 0; j < A.Length - 1 - i; j++)
            {
                if (A[j] > A[j + 1])
                {
                    aux = A[j];
                    A[j] = A[j + 1];
                    A[j + 1] = aux;
                }

                for (int k = 0; k < A.Length; k++)
                {
                    ArregloString += A[k] + " ";
                }
                Console.WriteLine(ArregloString.PadRight(35) + A[j].ToString().PadRight(3) + " " + A[j + 1].ToString().PadRight(9) + (i).ToString());
                ArregloString = ("");
            }
        }
    }
}
