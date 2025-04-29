namespace TDD.App
{
    public class Password
    {
        public bool VerificarNumero (string password)
        {
            bool numero = false;
            for (int i = 0; i < password.Length; i++)
            {
                if(char.IsDigit(password[i])) 
                    numero = true;
            }

            return numero;
        }

        public bool VerificarLongitud(string password)
        {
            return password.Length >= 8;
        }

        public bool VerificarMayuscula(string password)
        {
            bool mayuscula = false;

            for(int i = 0;i < password.Length; i++)
            {
                if(char.IsAsciiLetterUpper(password[i]))
                    mayuscula = true;
            }

            return mayuscula;
        }

        public bool VerificarSimbolo(string password)
        {
            bool simbolo = false;
            for (int i = 0; i < password.Length; i++)
            {
                if(char.IsPunctuation(password[i]))
                    simbolo = true;
            }

            return simbolo;
        }

        public bool EsSegura(string password)
        {
            return VerificarNumero(password) &&
                   VerificarLongitud(password) &&
                   VerificarMayuscula(password) &&
                   VerificarSimbolo(password);
        }
    }
}
