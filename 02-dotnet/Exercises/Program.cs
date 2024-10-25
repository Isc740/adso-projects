namespace Exercises {
    public class ExerciseHandler {
        public static void Main() {
            Ex19();
        }

        public static void Ex1() {
            Console.WriteLine("Tiene la lampara quemada? (Y / N)");
            char burnt = Console.ReadLine()[0];

            if (burnt == 'y') {
                Console.WriteLine("Tiene un reemplazo? (Y / N)");
                char replacement = Console.ReadLine()[0];

                if (replacement == 'y') {
                    Console.WriteLine("Use el reemplazo");
                }
                else {
                    Console.WriteLine("Vaya a la tienda y compre una nueva lampara.");
                }
            }
            else if (burnt == 'n') {
                Console.WriteLine("No hay nada que reemplazar");
            }
            else {
                Console.WriteLine("Valor ingresado no valido");
            }
        }

        public static void Ex2() {
            Console.WriteLine("Cuantos huevos quiere fritar? (1 / 3)");
            int eggs;
            bool numEggs = int.TryParse(Console.ReadLine(), out eggs);

            if (!numEggs || eggs != 3 && eggs != 1) {
                Console.WriteLine("Valor ingreado no valido");
                return;
            }

            Console.WriteLine("Agregale aceite a la sarten");

            if (eggs == 3) {
                Console.WriteLine("Rompa los 3 huevos en la sarten");
            }
            else {
                Console.WriteLine("Rompa el huevo en la sarten");
            }
            Console.WriteLine("Frite los huevos");
            Console.WriteLine("Sirvalos en un plato");
        }

        public static void Ex3() {
            Console.WriteLine("Hay pan? (Y / N): ");
            char isBread = Console.ReadLine()[0];

            if (isBread != 'y' && isBread != 'n' && isBread != 'Y' && isBread != 'N') {
                Console.WriteLine("Valor ingresado no valido");
                return;
            }

            Console.WriteLine("Dirijase a la tienda");
            Console.WriteLine("Pida el tipo de pan que prefiera");
            Console.WriteLine("Reciba el pan");
            Console.WriteLine("Vaya a la casa");
            Console.WriteLine("Guarde el pan");
        }

        public static void Ex4() {
            int height, width;

            Console.WriteLine("Ingrese el alto");
            bool heightResult = int.TryParse(Console.ReadLine(), out height);

            Console.WriteLine("Ingrese el ancho");
            bool widthResult = int.TryParse(Console.ReadLine(), out width);

            if (!heightResult || !widthResult) {
                Console.WriteLine("Valor ingresado no valido");
                return;
            }

            Console.WriteLine($"La base del rectangulo es: {height * width}");
        }

        public static void Ex5() {
            Console.WriteLine("Ingrese un numero para sacar la raiz cuadrada: ");
            int num;
            bool numT = int.TryParse(Console.ReadLine(), out num);

            if (!numT) {
                Console.WriteLine("Valor ingresado no es un numero");
                return;
            }

            Console.WriteLine($"La raiz cuadrada es: {Math.Sqrt(num)}");
        }

        public static void Ex6() {
            Console.WriteLine("Ingrese el largo: ");
            int height;
            bool heightT = int.TryParse(Console.ReadLine(), out height);

            Console.WriteLine("Ingrese el ancho");
            int width;
            bool widthT = int.TryParse(Console.ReadLine(), out width);

            if (!heightT || !widthT) {
                Console.WriteLine("Valor ingresado no es un numero");
                return;
            }

            Console.WriteLine($"El perimetro es: {(height * 2) + (width * 2)}");
        }

        public static void Ex7() {
            Console.WriteLine("Ingrese su nombre: ");
            string name = Console.ReadLine();

            Console.WriteLine("Ingrese su apellido");
            string lastName = Console.ReadLine();

            Console.WriteLine($"{name} {lastName}");
        }

        public static void Ex8() {
            Console.WriteLine("Ingrese el radio: ");
            int radius;
            bool radiusT = int.TryParse(Console.ReadLine(), out radius);

            if (radiusT && radius != 0) {
                Console.WriteLine($"El circunferencia es: {2 * (Math.PI * radius)}");
            }
            else {
                Console.WriteLine("Valor ingresado no es valido");
            }
        }

        public static void Ex9() {
            Console.WriteLine("Ingrese el radio: ");
            float radius;
            bool radiusT = float.TryParse(Console.ReadLine(), out radius);

            if (!radiusT || radius == 0.0) {
                Console.WriteLine("El valor ingresado no es valido");
                return;
            }

            Console.WriteLine($"{2 * (Math.PI * radius)}");
        }

        public static void Ex10() {
            Console.WriteLine("Ingrese el numero 1: ");
            int num1;
            bool num1T = int.TryParse(Console.ReadLine(), out num1);

            Console.WriteLine("Ingrese el numero 2: ");
            int num2;
            bool num2T = int.TryParse(Console.ReadLine(), out num2);

            if (!num1T || !num2T) {
                Console.WriteLine("Valor ingresado no valido");
                return;
            }

            if (num1 > num2) {
                Console.WriteLine($"{num1} es mayor que {num2}");
            }
            else {
                Console.WriteLine($"{num2} es mayor que {num1}");
            }
        }

        public static void Ex11() {
            Console.WriteLine("Ingrese el numero 1: ");
            int num1;
            bool num1T = int.TryParse(Console.ReadLine(), out num1);

            Console.WriteLine("Ingrese el numero 2: ");
            int num2;
            bool num2T = int.TryParse(Console.ReadLine(), out num2);

            if (!num1T || !num2T) {
                Console.WriteLine("Valor ingresado no valido");
                return;
            }

            if (num1 > num2) {
                Console.WriteLine($"{num1} es mayor que {num2}");
            }
            else if (num1 < num2) {
                Console.WriteLine($"{num2} es mayor que {num1}");
            }
            else {
                Console.WriteLine($"{num1} y {num2} son iguales");
            }
        }

        public static void Ex12() {
            Console.WriteLine("Ingrese el numero 1:");
            int num1;
            bool num1T = int.TryParse(Console.ReadLine(), out num1);

            Console.WriteLine("Ingrese el numero 2:");
            int num2;
            bool num2T = int.TryParse(Console.ReadLine(), out num2);

            if (!num1T || !num2T) {
                Console.WriteLine("Valor ingresado no valido");
                return;
            }

            if (num1 < 0) {
                num1 *= -1;
            }
            else if (num2 < 0) {
                num2 *= -1;
            }

            Console.WriteLine($"La suma es: {num1 + num2}");
        }

        public static void Ex13() {
            Console.WriteLine("Ingrese un numero natural: ");
            int num;
            bool numT = int.TryParse(Console.ReadLine(), out num);

            if (!numT || num > 12 || num < 1) {
                Console.WriteLine("Valor ingresado no valido");
                return;
            }

            Console.WriteLine("El numero esta en la primera decena");
        }

        public static void Ex14() {
            Console.WriteLine("Bienvenido al club Sol Naciente!");

            Console.WriteLine("Ingrese su antiguedad");
            int age;
            bool ageT = int.TryParse(Console.ReadLine(), out age);

            if (!ageT) {
                Console.WriteLine("Valor ingresado no valido");
                return;
            }

            Console.WriteLine("Ingrese su club: ");
            char club = Console.ReadLine()[0];


            if (club == 'A' || club == 'a' || (age >= 10 && age <= 20)) {
                Console.WriteLine("Socio Vip");
            }
            else {
                Console.WriteLine("Socio no Vip");
            }
        }

        public static void Ex15() {
            Console.WriteLine("Ingrese Pais:");
            string country = Console.ReadLine();

            Console.WriteLine("Ingrese capital");
            string capital = Console.ReadLine();

            Console.WriteLine($"La capital de {country} es {capital}");
        }

        public static void Ex16() {
            Console.WriteLine("Ingrese numero para sumar");
            int num;
            bool numT = int.TryParse(Console.ReadLine(), out num);

            if (!numT) {
                Console.WriteLine("Valor ingresado no valido");
                return;
            }

            Console.WriteLine($"la suma de {num} es {num + 1}");
        }

        public static void Ex17() {
            Console.WriteLine("Ingrese numero para disminuir al 25%");
            int num;
            bool numT = int.TryParse(Console.ReadLine(), out num);

            if (!numT) {
                Console.WriteLine("Valor ingresado no valido");
                return;
            }

            Console.WriteLine($"el valor disminuido un 25% es: {num * .25f}");
        }

        public static void Ex18() {
            Console.WriteLine("Ingrese las millas marinas: ");
            int miles;
            bool milesT = int.TryParse(Console.ReadLine(), out miles);

            if (!milesT) {
                Console.WriteLine("Valor ingresado no valido");
                return;
            }

            Console.WriteLine($"{miles} transformados a metros son: {miles * 1851.99932587}");
        }

        public static void Ex19() {
            Console.WriteLine("Ingrese su fecha de nacimiento: (YYYYMMDD)");
            int birthdate;
            bool birtdateT = int.TryParse(Console.ReadLine(), out birthdate);

            if (!birtdateT || birthdate.ToString().Length < 8) {
                Console.WriteLine("Valor ingresado no valido");
                return;
            }

            int year = birthdate / 10000;
            int month = (birthdate % 10000) / 100;
            int day = (birthdate % 100);

            DateTime now = DateTime.Now;

            int result = now.Year - year;
            if (month > now.Month || month == now.Month && day > now.Day) {
                result--;
            }

            Console.WriteLine($"Tu edad es: {result}");
        }

        public static void Ex20() {
            Console.WriteLine("Ingrese su edad:");
            int age;
            bool ageT = int.TryParse(Console.ReadLine(), out age);

            if (!ageT) {
                Console.WriteLine("Valor ingresado no valido");
                return;
            }

            if (age > 60) { Console.WriteLine("ADULTO MAYOR"); }
        }

        public static void Ex21() {
            Console.WriteLine("Ingrese la cantidad de dolares: ");
            int dolars;

            if (!int.TryParse(Console.ReadLine(), out dolars)) {
                Console.WriteLine("Valor ingresado no valido");
                return;
            }

            Console.WriteLine($"El equivalente de {dolars} a pesos son: {dolars * 4320.76f}");
        }

        public static void Ex22() {
            Console.WriteLine("Ingrese los grados celcius:");
            int degrees;

            if (!int.TryParse(Console.ReadLine(), out degrees)) {
                Console.WriteLine("Valor ingresado no valido");
                return;
            }

            Console.WriteLine($"{degrees} a grados son: {(1.8) * degrees + 32}");
        }
    }
}
