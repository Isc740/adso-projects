// See https://aka.ms/new-console-template for more information

/*using System;*/

struct UserData
{
    public int id;
    public int passwd;
    public int balance;
    public string name;
}

struct Result
{
    public int index;
    public bool result;
}

namespace atm
{
    class Atm
    {
        static UserData[] userDatabase = {
            new UserData {id = 1111, passwd = 111, balance = 500000, name = "Isaac"},
            new UserData {id = 2222, passwd = 222, balance = 500000, name = "Anderson"},
            new UserData {id = 3333, passwd = 333, balance = 500000, name = "Jhoan"},
            new UserData {id = 4444, passwd = 444, balance = 500000, name = "Matias"},
        };

        static void Main()
        {
            Console.WriteLine("Bienvenido al cajero automatico!");
            Console.WriteLine("Ingrese su id:");
            int id;
            bool idSuccess = int.TryParse(Console.ReadLine(), out id);

            Console.WriteLine("Ingrese su passwd");
            int passwd;
            bool passwdSuccess = int.TryParse(Console.ReadLine(), out passwd);

            if (!passwdSuccess && !idSuccess)
            {
                Console.WriteLine("Credenciales ingresadas no validas");
            }
            else
            {
                Result credentials = CheckCredentials(id, passwd);
            }
        }

        static Result CheckCredentials(int targetId, int targetPasswd)
        {
            Result result = new Result { index = -1, result = false };

            for (int i = 0; i < userDatabase.Length; i++)
            {
                if (userDatabase[i].id == targetId && userDatabase[i].passwd == targetPasswd)
                {
                    result.index = i;
                    result.result = true;
                }
            }
            return result;
        }

    }
}
