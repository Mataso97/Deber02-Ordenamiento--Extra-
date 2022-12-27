namespace _02._1_AlgoritmoPorSeleccion;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ALGORITMO POR SELECCION");
        // Inicializar el arreglo con valores aleatorios
        Random random = new Random();
        int[] A = new int[10];
        for (int i = 0; i < A.Length; i++)
        {
            A[i] = random.Next(1, 101);
        }

        // Mostrar el arreglo desordenado
        Console.Write("Arreglo desordenado: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write(A[i] + " ");
        }

        // Ordenar el arreglo
        Console.WriteLine("\n\nComienza ord. por seleccion".PadRight(37) + "Cambio".PadRight(10) + "Pasada");
        DateTime inicio = DateTime.Now;
        Seleccion(A);
        TimeSpan tiempoTranscurrido = DateTime.Now.Subtract(inicio);

        // Mostrar el arreglo ordenado
        Console.Write("\nArreglo ordenado por seleccion: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write(A[i] + " ");
        }
        Console.WriteLine($"\nTiempo de ejecución de Función: {tiempoTranscurrido.TotalMilliseconds} ms");
    }

    static void Seleccion(int[] A)
    {
        int i, j, indiceMenor;
        int aux;
        String ArregloString = ("");
        for (i = 0; i < A.Length - 1; i++)
        {
            indiceMenor = i;
            for (j = i + 1; j < A.Length; j++)
            {
                if (A[j] < A[indiceMenor])
                {
                    indiceMenor = j;
                }
            }
            aux = A[indiceMenor];
            A[indiceMenor] = A[i];
            A[i] = aux;
            for (int k = 0; k < A.Length; k++)
            {
                ArregloString += A[k] + " ";
            }
            Console.WriteLine(ArregloString.PadRight(35) + A[indiceMenor].ToString().PadRight(3) + " " + A[i].ToString().PadRight(9) + (i).ToString());
            ArregloString = ("");
        }
    }
}
