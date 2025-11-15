namespace Helix.Core.Recursividade
{
    public class FatorialRecursivo
    {
        public static int Fatorial(int n)
        {
            // caso base
            if(n == 0)
            {
                return 1;
            }

            // passo recursivo
            return n * Fatorial(n - 1);
        }
    }
}