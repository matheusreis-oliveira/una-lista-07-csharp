class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("Escolha um exemplo para visualizar:");
            Console.WriteLine("1. Lista");
            Console.WriteLine("2. Pilha");
            Console.WriteLine("3. Insertion Sort");
            Console.WriteLine("4. Shell Sort");
            Console.WriteLine("5. Sair");
            Console.Write("Opção: ");

            try
            {
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        ShowListExample();
                        Pause();
                        break;
                    case 2:
                        ShowStackExample();
                        Pause();
                        break;
                    case 3:
                        ShowInsertionSortExample();
                        Pause();
                        break;
                    case 4:
                        ShowShellSortExample();
                        Pause();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Pressione Enter para tentar novamente.");
                        Pause();
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número.");
                Pause();
            }
        }
    }

    static void ShowListExample()
    {
        Console.Clear();

        var lista = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine("Exemplo de Lista:");
        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }
    }

    static void ShowStackExample()
    {
        Console.Clear();

        var pilha = new Stack<int>();
        pilha.Push(1);
        pilha.Push(2);
        pilha.Push(3);

        Console.WriteLine("Exemplo de Pilha:");
        while (pilha.Count > 0)
        {
            Console.WriteLine(pilha.Pop());
        }
    }

    static void ShowInsertionSortExample()
    {
        Console.Clear();

        int[] vetor = { 1, 100, 30, 50, 11, 13, 5, 7, 78 };
        InsertionSort(vetor);

        Console.WriteLine("Vetor após Insertion Sort:");
        foreach (var num in vetor)
        {
            Console.WriteLine(num);
        }
    }

    static void InsertionSort(int[] vetor)
    {
        for (int i = 1; i < vetor.Length; i++)
        {
            int key = vetor[i];
            int j = i - 1;
            while (j >= 0 && vetor[j] > key)
            {
                vetor[j + 1] = vetor[j];
                j = j - 1;
            }
            vetor[j + 1] = key;
        }
    }

    static void ShowShellSortExample()
    {
        Console.Clear();

        int[] vetor = { 1, 100, 30, 50, 11, 13, 5, 7, 78 };
        ShellSort(vetor);

        Console.WriteLine("Vetor após Shell Sort:");
        foreach (var num in vetor)
        {
            Console.WriteLine(num);
        }
    }

    static void ShellSort(int[] vetor)
    {
        int n = vetor.Length;
        for (int gap = n / 2; gap > 0; gap /= 2)
        {
            for (int i = gap; i < n; i++)
            {
                int temp = vetor[i];
                int j;
                for (j = i; j >= gap && vetor[j - gap] > temp; j -= gap)
                {
                    vetor[j] = vetor[j - gap];
                }
                vetor[j] = temp;
            }
        }
    }

    static void Pause()
    {
        Console.WriteLine("\nPressione Enter para continuar.");
        Console.ReadLine();
    }
}
