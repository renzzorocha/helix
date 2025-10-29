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
    
    
}