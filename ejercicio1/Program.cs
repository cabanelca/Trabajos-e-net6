

    double producto;
    double resultado;

    Console.WriteLine("Ingrese un monto de un producto");
    producto = int.Parse(Console.ReadLine());
    resultado = producto * 0.21;
    Console.WriteLine("El iva es " + resultado);
    Console.WriteLine("El monto final es " +(resultado + producto));
    Console.ReadLine();
