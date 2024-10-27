namespace Exercises {
    public class ExerciseHandler {
        public static void Main() {
            // Decidí convertir a cada ejercicio en un metodo de esta clase.
            // llama el ejercicio que quieras usando Ex{N}();

            Ex26();
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

            Console.WriteLine("Ingrese el alto:");
            bool heightResult = int.TryParse(Console.ReadLine(), out height);

            Console.WriteLine("Ingrese el ancho:");
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

            Console.WriteLine("Ingrese el ancho:");
            int width;
            bool widthT = int.TryParse(Console.ReadLine(), out width);

            if (!heightT || !widthT) {
                Console.WriteLine("Valor ingresado no es un numero");
                return;
            }

            Console.WriteLine($"El perimetro es: {(height * 2) + (width * 2)}");
        }

        public static void Ex7() {
            Console.WriteLine("Ingrese su nombre:");
            string name = Console.ReadLine();

            Console.WriteLine("Ingrese su apellido:");
            string lastName = Console.ReadLine();

            Console.WriteLine($"{name} {lastName}");
        }

        public static void Ex8() {
            Console.WriteLine("Ingrese el radio:");
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
            Console.WriteLine("Ingrese el radio:");
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
            if (num2 < 0) {
                num2 *= -1;
            }
            Console.WriteLine($"{num1} {num2}");

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

            Console.WriteLine("Ingrese su antiguedad:");
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
            Console.WriteLine("Ingrese numero para sumar:");
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

        public static void Ex23() {

            Console.WriteLine("Ingrese nota 1:");
            int note1;
            bool note1T = int.TryParse(Console.ReadLine(), out note1);

            Console.WriteLine("Ingrese nota 2:");
            int note2;
            bool note2T = int.TryParse(Console.ReadLine(), out note2);

            Console.WriteLine("Ingrese nota 3:");
            int note3;
            bool note3T = int.TryParse(Console.ReadLine(), out note3);

            if (!note3T || !note2T || !note1T) {
                Console.WriteLine("Valor ingreado no valido");
                return;
            }

            float result = (float)((note1 * .20) + (note2 * .30) + (note3 * .50)) / 3;

            Console.WriteLine($"El resultado es: {result}");

            if (result >= 3.5) {
                Console.WriteLine("Puede habilitar");
            }
            else if (result > 2.0) {
                Console.WriteLine("No puede habilitar");
            }
        }

        public static void Ex24() {
            Console.WriteLine("Ingrese el precio de una unidad:");
            int price;
            bool priceT = int.TryParse(Console.ReadLine(), out price);

            Console.WriteLine("Ingrese la cantidad de las unidades:");
            int units;
            bool unitsT = int.TryParse(Console.ReadLine(), out units);

            if (!unitsT || !priceT) {
                Console.WriteLine("Valor ingresado no valido");
                return;
            }

            int comission = price * units;
            int comissionType = 0;
            if (units >= 500 && units <= 999) {
                comission -= (int)Math.Round(comission * .05);
                comissionType = 5;
            }
            else if (units > 999) {
                comission -= (int)Math.Round(comission * .10);
                comissionType = 10;
            }

            Console.WriteLine($"Su comision es del: {comissionType}%");
            Console.WriteLine($"Su comision es: {comission}");
        }

        public static void Ex25() {

            List<int> result = new List<int>();

            int[] nums = new int[20];
            bool numsT;
            for (int i = 0; i < 20; i++) {
                Console.WriteLine($"Ingrese el numero {i + 1}:");
                numsT = int.TryParse(Console.ReadLine(), out nums[i]);

                if (!numsT) {
                    Console.WriteLine("Ingrese un numero entero");
                    i--;
                }
                else if (nums[i] >= 25) {
                    result.Add(nums[i]);
                }
            }

            Console.WriteLine("Los numeros mayores o iguales a 25 son:");

            for (int i = 0; i < result.Count; i++) {
                Console.WriteLine($"{result[i]}");
            }
        }

        public static void Ex26() {
            int[] nums = new int[10];
            int acc = 0;
            for (int i = 0; i < nums.Length; i++) {
                Console.WriteLine($"Ingrese el numero {i + 1}:");
                bool numsT = int.TryParse(Console.ReadLine(), out nums[i]);

                if (!numsT) {
                    Console.WriteLine("Ingrese un numero entero");
                    i--;
                }
                else {
                    acc += nums[i];
                }
            }

            Console.WriteLine($"La suma de los numeros es: {acc}");
            Console.WriteLine($"El promedio de los numeros es: {acc / nums.Length}");
        }

        public static void Ex27() {
            int minors = 0;
            int adults = 0;
            int seniors = 0;

            for (int i = 0; i < 10; i++) {
                Console.WriteLine($"{i + 1} Ingrese su edad:");
                int age;
                bool agesT = int.TryParse(Console.ReadLine(), out age);

                if (!agesT) {
                    Console.WriteLine("Ingrese un numero entero");
                    i--;
                }
                else if (age < 18) {
                    minors++;
                }
                else if (age >= 18) {
                    adults++;
                    if (age >= 60) {
                        seniors++;
                    }
                }
            }

            Console.WriteLine($"El numero de menores son: {minors}");
            Console.WriteLine($"El numero de adultos son: {adults}");
            Console.WriteLine($"El numero de mayores son: {seniors}");
        }
    }
}
