using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViernesProgramacion1
{
    using Microsoft.Win32.SafeHandles;
    using System;

    class MainClass
    {
        public static void Main(string[] args)
        {
            // a continuacion explicare lo que hace mi codigo "modificado e inspirado de esta pagina
            //https://es.stackoverflow.com/questions/454001/quiero-determinar-si-un-string-dado-es-palíndromo-capicúa-o-no-pero-no-funciona
            // con un poco mas de informacion para practicar y lo hecho en clase con usted 
            // por favor tenme paciencia , que me cuesta aprender porque soy algo lento 

            Console.WriteLine("Hola , mucho gusto , soy la IA mas aburrida del mundo ");
            Console.WriteLine("jugaremos si la palabras que ingras mas al rato es palindromo o no, pero primero ");
            Console.WriteLine("Necesito un nombre de usuario para referirme a usted y darle un mejor servicio ");
            string NombreUsuario = Console.ReadLine();
            Console.WriteLine("muchos gusto  " + NombreUsuario + " sempai sama , supremo kayosama OwO");

            string Palindromo;
            string PalindromoAlReves = "";
            char Letras;
            bool ElPalindromo;

            //estas son mis variablñes con nombres para representarlas a continaucion 

            int NumLetrasPalindromo = 20;
            int NumVocales;
            int NumSilabas;



            //estas son para que me cuente mis vocales y silabas y el numero de letras de la palabra 


            Console.WriteLine("Ingrese una palabra para determinar si es palíndromo o no");

            // aqui indico al usuario que a continuacion ingresara la palabra

            Palindromo = Console.ReadLine();

            //entonces mi variable string Palindromo aacedo a esta que es igual a lo que ingresa el usuario 

            ElPalindromo = true;

            // le concedo a mi boleano una de las 2 opciones , en este caso que es " verdadero"


            for (int Num = Palindromo.Length - 1; Num >= 0; Num--)

            // pensando en numeros binarios 
            // para , en parentesis tengo la opoeracion que ara a continuacion
            // una variable que vale en numero entero que le doy un nombre , en este caso j ,
            // es igual al numero binario que representa la palabra que el usuario tecleo
            // asignamos y apuntamos al elemento con desplazamiento length - n desde el inicio de una secuencia 
            //entonces mi numero entero int Num es igual o menor a 0 o un numero negativo , por ser cosa de que la compu
            // lee en numero binarios y no en letras , pero le indico que debe hacerlo , porque es estupida y no sabe 
            // como posiblemente yo en explicando XD

            {
                char letras = Convert.ToChar(Palindromo[Num]);

                // es entonces que mi variable char entra en accion ,
                // necesito que asigne a convertir al char y realice la operacion accediendo al string Palindromo
                // para ver si es nulo o no en cuestion de numeros en mi variable int Num

                PalindromoAlReves += letras.ToString();

                // activo mi string y requiero que ña suma e igual de letras escritas , accediendo al string que
                // escribio el 
                //usuario que se encuentra en mi parentesis y debe otorgarme un resultado null o no 
            }


            if (Palindromo == PalindromoAlReves)
            {
                ElPalindromo = false;

                //si fuera el caso que mi string Palindromo es verdaderamente escrito en mi string PalindromoAlRevez
                // es entonces que mi bool se activa 
                // aqui tengo una duda desde el incio que viumos booleanos pero se me genero despues y me daba pena
                // preguntar porque me hacen bulling por ser pendejo XD que ni me quejo tanto , es chistoso aveces 
                //¿ porque yo cuando leo mi coidgo entiendo que
                //lo leo al revez pero funciona lo contrario de lo que creo que leo que es 
                // porque yo entiendo que mi resultado de mi Bool es falso pero mis strings son verdaderamente iguales
            }

            if (ElPalindromo)
            {
                Console.WriteLine("La palabra ingresada no es palindromo");

            }
            else if (ElPalindromo == false)// pero aqui si es verdaderamente falso pero si es un palindormo ,no entiendoXD
            {
                Console.WriteLine("La palabra ingresada si es palindromo");
            }


            //hasta aqui termina de hacer si es o no un palindormo


            //aqui comienza que mi codigo cuenta las letras , silabas y vocales de la palabra escrita y no se porque no jala



            Console.WriteLine(" por favor ingresa la palabra de nuevo que ingresaste  ");
            string Palabra; Console.ReadLine();
            string Respuesta = Console.ReadLine();
            while (Respuesta != "Si")
            {

                for (int i = 0; i < Palindromo.Length; i++) ;
                {
                    Console.WriteLine("Sempai el resultado es " + Palindromo[NumLetrasPalindromo]);
                }
                for (int i = '0'; i < 'o'; i++)
                {
                    if (Palindromo[i] == 'a' || Palindromo[i] == 'e' || Palindromo[i] == 'i' || Palindromo[i] == 'o' || Palindromo[i] == 'u')
                    {

                    }
                }

                int[] num = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
                for (int i = 0; i < num.Length; (i)++)
                {
                    if ((num[1] % 2) == 0)
                    {
                        Console.WriteLine(num[i] + " no es par");
                    }
                    else
                    {
                        { }
                    }
                }
            Console.WriteLine("tambien puedes regresar a contar las palabnras si escribes " + "Si" + NombreUsuario +  " sempai sama , supremo kayosama");
                Respuesta = Console.ReadLine();
            }

        }
    }
}




