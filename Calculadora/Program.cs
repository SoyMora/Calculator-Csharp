using System.Xml.Serialization;
using System.Threading;
static int Suma(int primerNumero, int segundoNumero){
    return primerNumero + segundoNumero;
}

static int Resta(int primerNumero, int segundoNumero){
    return primerNumero - segundoNumero;
}

static int Multiplicacion(int primerNumero, int segundoNumero){
    return primerNumero * segundoNumero;
}

static int Division(int primerNumero, int segundoNumero){
    return primerNumero / segundoNumero;
}

    int numeroUno;
    int numeroDos;

    while(true){

    try{
    System.Console.WriteLine("Bienvenido a Calculadora en C#");
    System.Console.WriteLine("\n¿Que quieres hacer?");
    System.Console.WriteLine("\n1.- Sumar"+
    "\n2.- Restar"+
    "\n3.- Multiplicar"+
    "\n4.- Dividir"+
    "\n5.- Salir");
    int OpcionSeleccionada = Convert.ToInt32(Console.ReadLine());
    switch(OpcionSeleccionada){
        case 1:
        System.Console.WriteLine("Porfavor coloque el primer número");
        numeroUno = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Porfavor coloque el segundo número");
        numeroDos = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(Suma(numeroUno, numeroDos));
        Console.ReadKey();
        
        break;

        case 2:
        System.Console.WriteLine("Porfavor coloque el primer número");
        numeroUno = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Porfavor coloque el segundo número");
        numeroDos = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(Resta(numeroUno, numeroDos));
        Console.ReadKey();
        break;


        case 3:
        System.Console.WriteLine("Porfavor coloque el primer número");
        numeroUno = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Porfavor coloque el segundo número");
        numeroDos = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(Multiplicacion(numeroUno, numeroDos));
        Console.ReadKey();
        break;


        case 4:
        System.Console.WriteLine("Porfavor coloque el primer número");
        numeroUno = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Porfavor coloque el segundo número");
        numeroDos = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(Division(numeroUno, numeroDos));
        Console.ReadKey();
        break;


        case 5:
        System.Console.WriteLine("Saliendo...");
        Thread.Sleep(2);
        return;


        default:
        System.Console.WriteLine("Por favor ingrese un número valido");
        Console.ReadKey();
        break;
    }
    }catch(Exception ex){
        System.Console.WriteLine($"Ha ocurrido el error: {ex.Message}");
        Console.ReadKey();
    }

}
