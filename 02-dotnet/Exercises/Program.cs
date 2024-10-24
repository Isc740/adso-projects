namespace Exercises
{

    public class Initialize
    {
        public static void Main()
        {
            Ex23.Run();
        }
    }

    public class Ex1
    {
        public static void Run()
        {
            Console.WriteLine("Tiene la lampara quemada? (Y / N)");
            char burnt = Console.ReadLine()[0];

            if (burnt == 'y')
            {
                Console.WriteLine("Tiene un reemplazo? (Y / N)");
                char replacement = Console.ReadLine()[0];

                if (replacement == 'y')
                {
                    Console.WriteLine("Use el reemplazo");
                }
                else
                {
                    Console.WriteLine("Vaya a la tienda y compre una nueva lampara.");
                }
            }
            else if (burnt == 'n')
            {
                Console.WriteLine("No hay nada que reemplazar");
            }
            else
            {
                Console.WriteLine("Valor ingresado no valido");
            }
        }
    }

    public class Ex2
    {
        public static void Run()
        {
            Console.WriteLine("Cuantos huevos quiere fritar? (1 / 3)");
            int eggs;
            bool numEggs = int.TryParse(Console.ReadLine(), out eggs);

            if (!numEggs || eggs != 3 && eggs != 1)
            {
                Console.WriteLine("Valor ingreado no valido");
                return;
            }

            Console.WriteLine("Agregale aceite a la sarten");

            if (eggs == 3)
            {
                Console.WriteLine("Rompa los 3 huevos en la sarten");
            }
            else
            {
                Console.WriteLine("Rompa el huevo en la sarten");
            }
            Console.WriteLine("Frite los huevos");
            Console.WriteLine("Sirvalos en un plato");
        }
    }

    public class Ex3
    {
        public static void Run()
        {
            Console.WriteLine("Hay pan? (Y / N): ");
            char isBread = Console.ReadLine()[0];

            if (isBread != 'y' && isBread != 'n' && isBread != 'Y' && isBread != 'N')
            {
                Console.WriteLine("Valor ingresado no valido");
                return;
            }

            Console.WriteLine("Dirijase a la tienda");
            Console.WriteLine("Pida el tipo de pan que prefiera");
            Console.WriteLine("Reciba el pan");
            Console.WriteLine("Vaya a la casa");
            Console.WriteLine("Guarde el pan");
        }
    }
}

public class Ex4
{
    public static void Run()
    {
        int height;
        Console.WriteLine("Ingrese el alto");
        bool heightResult = int.TryParse(Console.ReadLine(), out height);

        int width;
        Console.WriteLine("Ingrese el hancho");
        bool widthResult = int.TryParse(Console.ReadLine(), out width);

        if (!heightResult || !widthResult)
        {
            Console.WriteLine("Valor ingresado no valido");
            return;
        }

        Console.WriteLine($"La base del rectangulo es: {height * width}");
    }
}

public class Ex5
{
    public static int Run()
    {
        int num;
        Console.WriteLine("Ingrese un numero para sacar la raiz cuadrada: ");
        bool numT = int.TryParse(Console.ReadLine(), out num);

        if (!numT)
        {
            Console.WriteLine("Valor ingreado no es un numero");
            return -1;
        }

        Console.WriteLine($"La raiz cuadrada es: {Math.Sqrt(num)}");

        return 0;
    }
}

public class Ex6
{
    public static int Run()
    {
        int height;
        Console.WriteLine("Ingrese el largo: ");
        bool heightT = int.TryParse(Console.ReadLine(), out height);

        int width;
        Console.WriteLine("Ingrese el ancho");
        bool widthT = int.TryParse(Console.ReadLine(), out width);

        if (!heightT || !widthT)
        {
            Console.WriteLine("Valor ingresado no es un numero");
            return -1;
        }

        Console.WriteLine($"El perimetro es: {(height * 2) + (width * 2)}");

        return 0;
    }
}

public class Ex7
{
    public static int Run()
    {
        Console.WriteLine("Ingrese su nombre: ");
        string name = Console.ReadLine();

        Console.WriteLine("Ingrese su apellido");
        string lastName = Console.ReadLine();

        Console.WriteLine($"{name}{lastName}");

        return 0;
    }
}

public class Ex8
{
    public static int Run()
    {
        int radius;
        Console.WriteLine("Ingrese el radio: ");
        bool radiusT = int.TryParse(Console.ReadLine(), out radius);

        if (radiusT && radius != 0)
        {
            Console.WriteLine($"{2 * (Math.PI * radius)}");
            return 0;
        }

        return -1;
    }
}

public class Ex9
{
    public static int Run()
    {
        float radius;
        Console.WriteLine("Ingrese el radio: ");
        bool radiusT = float.TryParse(Console.ReadLine(), out radius);

        if (!radiusT || radius == 0.0)
        {
            Console.WriteLine("El valor ingresado no es valido");
            return -1;
        }

        Console.WriteLine($"{2 * (Math.PI * radius)}");
        return 0;
    }
}

public class Ex10
{
    public static int Run()
    {
        Console.WriteLine("Ingrese el numero 1: ");
        int num1;
        bool num1T = int.TryParse(Console.ReadLine(), out num1);

        Console.WriteLine("Ingrese el numero 2: ");
        int num2;
        bool num2T = int.TryParse(Console.ReadLine(), out num2);

        if (!num1T || !num2T)
        {
            Console.WriteLine("Valor ingresado no valido");
            return -1;
        }

        if (num1 > num2)
        {
            Console.WriteLine($"{num1} es mayor que {num2}");
        }
        else
        {
            Console.WriteLine($"{num2} es mayor que {num1}");
        }

        return 0;
    }
}

public class Ex11
{
    public static int Run()
    {
        Console.WriteLine("Ingrese el numero 1: ");
        int num1;
        bool num1T = int.TryParse(Console.ReadLine(), out num1);

        Console.WriteLine("Ingrese el numero 2: ");
        int num2;
        bool num2T = int.TryParse(Console.ReadLine(), out num2);

        if (!num1T || !num2T)
        {
            Console.WriteLine("Valor ingresado no valido");
            return -1;
        }

        if (num1 > num2)
        {
            Console.WriteLine($"{num1} es mayor que {num2}");
        }
        else if (num1 < num2)
        {
            Console.WriteLine($"{num2} es mayor que {num1}");
        }
        else
        {
            Console.WriteLine($"{num1} y {num2} son iguales");
        }

        return 0;
    }
}

public class Ex12
{
    public static int Run()
    {
        Console.WriteLine("Ingrese el numero 1:");
        int num1;
        bool num1T = int.TryParse(Console.ReadLine(), out num1);

        Console.WriteLine("Ingrese el numero 2:");
        int num2;
        bool num2T = int.TryParse(Console.ReadLine(), out num2);

        if (!num1T || !num2T)
        {
            Console.WriteLine("Valor ingresado no valido");
            return -1;
        }

        if (num1 < 0)
        {
            num1 *= -1;
        }
        else if (num2 < 0)
        {
            num2 *= -1;
        }

        Console.WriteLine($"La suma es: {num1 + num2}");

        return 0;
    }
}

public class Ex13
{
    public static int Run()
    {
        Console.WriteLine("Ingrese un numero natural: ");
        int num;
        bool numT = int.TryParse(Console.ReadLine(), out num);

        if (!numT || num > 12 || num < 1)
        {
            Console.WriteLine("Valor ingresado no valido");
            return -1;
        }

        Console.WriteLine("El numero esta en la primera decena");
        return 0;
    }
}

public class Ex14
{
    public static int Run()
    {
        Console.WriteLine("Bienvenido al club Sol Naciente!");

        Console.WriteLine("Ingrese su antiguedad");
        int age;
        bool ageT = int.TryParse(Console.ReadLine(), out age);

        if (!ageT)
        {
            Console.WriteLine("Valor ingresado no valido");
            return -1;
        }

        Console.WriteLine("Ingrese su club: ");
        char club = Console.ReadLine()[0];


        if (club == 'A' || club == 'a' || (age >= 10 && age <= 20))
        {
            Console.WriteLine("Socio Vip");
        }
        else
        {
            Console.WriteLine("Socio no Vip");
        }

        return 0;
    }
}

public class Ex15
{
    public static int Run()
    {
        Console.WriteLine("Ingrese Pais:");
        string country = Console.ReadLine();

        Console.WriteLine("Ingrese capital");
        string capital = Console.ReadLine();

        Console.WriteLine($"La capital de {country} es {capital}");

        return 0;
    }
}

public class Ex16
{
    public static int Run()
    {
        Console.WriteLine("Ingrese numero para sumar");
        int num;
        bool numT = int.TryParse(Console.ReadLine(), out num);

        if (!numT)
        {
            Console.WriteLine("Valor ingresado no valido");
            return -1;
        }

        Console.WriteLine($"la suma de {num} es {num + 1}");
        return 0;
    }
}

public class Ex17
{
    public static int Run()
    {
        Console.WriteLine("Ingrese numero para disminuir al 25%");
        int num;
        bool numT = int.TryParse(Console.ReadLine(), out num);

        if (!numT)
        {
            Console.WriteLine("Valor ingresado no valido");
            return -1;
        }

        Console.WriteLine($"el valor disminuido un 25% es: {num * .25f}");
        return 0;
    }
}

public class Ex18
{
    public static int Run()
    {
        Console.WriteLine("Ingrese las millas marinas: ");
        int miles;

        if (!int.TryParse(Console.ReadLine(), out miles))
        {
            Console.WriteLine("Valor ingresado no valido");
            return -1;
        }

        Console.WriteLine($"{miles} transformados a metros son: {miles * 1851.99932587}");
        return 0;
    }
}

public class Ex20
{
    public static int Run()
    {
        Console.WriteLine("Ingrese su fecha de nacimiento: ");
        int birthAge;

        if (!int.TryParse(Console.ReadLine(), out birthAge))
        {
            Console.WriteLine("Valor ingresado no valido");
            return -1;
        }

        Console.WriteLine($"Tu edad es: {2024 - birthAge}");

        return 0;
    }
}

public class Ex21
{
    public static int Run()
    {
        Console.WriteLine("Ingrese la cantidad de dolares: ");
        int dolars;

        if (!int.TryParse(Console.ReadLine(), out dolars))
        {
            Console.WriteLine("Valor ingresado no valido");
            return -1;
        }

        Console.WriteLine($"El equivalente de {dolars} a pesos son: {dolars * 4320.76f}");
        return 0;
    }
}

public class Ex22
{
    public static int Run()
    {
        Console.WriteLine("Ingrese los grados celcius:");
        int degrees;

        if (!int.TryParse(Console.ReadLine(), out degrees))
        {
            Console.WriteLine("Valor ingresado no valido");
            return -1;
        }

        Console.WriteLine($"{degrees} a grados son: {(1.8) * degrees + 32}");

        return 0;
    }
}

public class Ex23
{
    public static int Run()
    {
        Console.WriteLine("Ingrese nota 1:");
        int note1;
        bool note1T = int.TryParse(Console.ReadLine(), out note1);

        Console.WriteLine("Ingrese nota 2:");
        int note2;
        bool note2T = int.TryParse(Console.ReadLine(), out note2);

        Console.WriteLine("Ingrese nota 3:");
        int note3;
        bool note3T = int.TryParse(Console.ReadLine(), out note3);

        if (!note3T || !note2T || !note1T)
        {
            Console.WriteLine("Valor ingreado no valido");
            return -1;
        }

        double result = ((note1 * .20) + (note2 * .30) + (note3 * .50)) / 3;

        Console.WriteLine($"El resultado{result}");

        if (result >= 3.5)
        {
            Console.WriteLine("Puede habilitar");
        }
        else if (result > 2.0)
        {
            Console.WriteLine("No puede habilitar");
        }

        return 0;
    }
}
