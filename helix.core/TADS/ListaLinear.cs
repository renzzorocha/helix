namespace helix.core.TADS;

public class ListaLinear
{
    private int[] elementos;
    private int inicio;
    private int fim;
    private int capacidade;

    public ListaLinear(int tamanho)
    {
        capacidade = tamanho;
        elementos = new int[capacidade];
        inicio = 0;
        fim = 0;
    }

    public bool IsEmpty()
    {
        return fim == inicio;
    }

    public bool IsFull()
    {
        return fim == capacidade;
    }

    public int Size()
    {
        return fim - inicio;
    }

    public void Insert(int item, int index)
    {
        if (IsFull())
        {
            Console.WriteLine("Erro: Lista cheia");
            return;
        }

        if (index < 0 || index > Size())
        {
            Console.WriteLine("Erro: Index inválido");
            return;
        }

        for (int i = fim; i > index; i--)
        {
            elementos[i] = elementos[i - 1];
        }

        elementos[index] = item;
        fim++;
    }
    public int Remove(int index)
    {
        if (IsEmpty())
        {
            Console.WriteLine("Erro: Lista Vazia");
            return -1;
        }

        if (index < 0 || index > Size())
        {
            Console.WriteLine("Erro: Index inválido");
            return -1;
        }

        int aux = elementos[index];

        for (int i = index; i < fim; i++)
        {
            elementos[i] = elementos[i + 1];
        }

        fim--;

        return aux;
    }
    
    public int Get(int index)
    {
        if (IsEmpty())
        {
            Console.WriteLine("Erro: Lista Vazia");
            return -1;
        }

        if (index < 0 || index > Size())
        {
            Console.WriteLine("Erro: Index inválido");
            return -1;
        }

        return elementos[index];
    }

    public void Set(int item, int index)
    {
        if (index < 0 || index > Size())
        {
            Console.WriteLine("Erro: Index inválido");
        }

        elementos[index] = item;
    }
}