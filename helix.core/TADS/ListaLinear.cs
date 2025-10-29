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