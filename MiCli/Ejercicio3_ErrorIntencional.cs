namespace MiCli;

// TODO: Declara una constante e intenta cambiar su valor para ver el error
public class Ejercicio3_ErrorIntencional
{
    public static string UsarConstanteCorrectamente()
    {
        // TODO: Declara una constante int
        // Las constantes  yo la defini con 'const' y no puede cambia el valor
        const int miNumeroFijo = 100;
        // TODO: Intenta cambiar su valor en la siguiente línea (esto causará un error)
        // TODO: Lee el error que te da Visual Studio
        // TODO: Comenta la línea que causa el error
        // miNumeroFijo = 300;  <-- Ponle las dos barras // al principio
        // TODO: Retorna un mensaje con el valor de la constante
        return "El valor de la constante es: " + miNumeroFijo;//OJO: reemplaza este texto
        throw new NotImplementedException();
    }
    
    public static void Ejecutar()
    {
        Console.WriteLine(UsarConstanteCorrectamente());
    }
}
