// Actividad 3

/* 

Crea una estructura de datos para un cliente con estos campos:

Nombre completo

Teléfono

Dirección

Email

Si es nuevo cliente

Bonus: escribe un método para presentar estos datos desde la estructura al
hacer Console.WriteLine(...)

*/

Cliente micliente = new Cliente();

micliente.NombreCompleto = "Juan Pérez";
micliente.Telefono = "123456789";
micliente.Direccion = "Calle 123, Madrid";
micliente.Email = "juanperez@example.com";
micliente.EsNuevoCliente = true;

micliente.PresentarCliente();

public struct Cliente
{
    public string NombreCompleto;
    public string Telefono;
    public string Direccion;
    public string Email;
    public bool EsNuevoCliente;

    public void PresentarCliente()
    {
        Console.WriteLine("Nombre completo: " + NombreCompleto);
        Console.WriteLine("Teléfono: " + Telefono);
        Console.WriteLine("Dirección: " + Direccion);
        Console.WriteLine("Email: " + Email);
        Console.WriteLine("Es nuevo cliente: " + (EsNuevoCliente ? "Sí" :
        "No"));
    }
}