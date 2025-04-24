namespace TDD.App;

public class Funciones
{
    public int Sumar(int dato1, int dato2)
    {
        return dato1 + dato2;
    }

    public bool EsPalindrome(string text)
    {
        var reverse = new string(text.Reverse().ToArray());
        text = text.Replace(" ", "");
        reverse = reverse.Replace(" ", "");
        return reverse.ToLower().Equals(text.ToLower());
    }
    
    public int ObtenerMayor(int[] numeros)
    {
        int mayor = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] > mayor)
                mayor = numeros[i];
        }

        return mayor;
    }

}