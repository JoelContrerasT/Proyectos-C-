using System; 


namespace CSharepHelloWorld
{
    class HelloWorld
    {
     static void Main(string[] args)
        {
        //Este es un comentario
        Console.Writeline("Hello, World!");

        /* 
        Esto
        es
        un
        comentario
        multi
        lineal
        
        */

            string myString = "Esto es una cadena de texto";
            Console.Writeline(myString);

            int myInt = 7;
            myInt = myInt + 4

            Console.Writeline(myInt);
            Console.Writeline(myInt - 1);
            Console.Writeline(myInt);

            double myDouble = 6.5;
            Console.Writeline(myDouble)
            
            float myFloat = 6.5f;
            Console.Writeline(myFloat)

            Console.Writeline(myInt + myDouble + myFloat)

            bool myBool = true;
            Console.Writeline(myBool)

            dynamic myDynamic =6;
            myDynamic = "Mi dato dinámico";
            Console.Writeline(myDynamic + myFloat);

            var myVar = "Mi variable de tipo inferido";
            Console.Writeline(myVar);

            Console.Writeline($"El valor de mi entero es {myInt} y el de mi bool {myBool}");

            const string MyConst = "Mi constante"
            Consola.Writeline(MyConst)

            //Estructuras

            var myArray = new string[] {"Joel", "Contreras", "Toloza"};
            Console.Writeline(myArray[0]);

            myArray[2] = "36";
            Console.Writeline(myArray[2]);

            var myDiccionary = new Dictionary<string, int> 
            {
                {"Joel", 19},
                {"Kristy", 21},
                {"Diego", 18}
            };

            Console.Writeline(myDiccionary["Joel"]);

            var mySet = new HashSet<string> {"Joel", "Contreras", "Toloza"}
            Console.Writeline(mySet[0]);

            var myTuple = ("Joel", "Contreras", "Toloza");
            Console.Writeline(myTuple);

            // Bucles

            for(int index = 0; index < 10; index++)
            {
                Console.Writeline(index);
            }

            foreach (var myItem in myDiccionary)
             {
                Console.Writeline(myItem);
            }

             foreach (var myItem in myArray)
             {
                Console.Writeline(myItem);
            }

            // Flujos

            if(myInt == 11 && myBool == true)
            {
                Console.Writeline("El valor es 11");
            }
            else if (myInt == 12 || myBool == false)
            else
            {
                Console.Writeline("El valor no es 11");
            }

            // Funciones

            MyFuncition();
            Console.Writeline(MyFunctionWithReturn(5));

            //Clases

            var myClass = new MyClass();
            Console.Writeline(MyClass)

        }
        void MyFuncition()
         {
            Console.Writeline("Mi función")
         }

         static int MyFunctionWithReturn(int param)
         {
            return 10 + param
         }

         class MyClass
         {
            public string myName { get; set; };

            public MyClass(string myName)
            {
                this.myName = myName;
            }
         }
    }

    
}
