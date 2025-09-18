namespace Bibliote.Models;

public class Persona
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string DNI { get; set; }

    public string Email { get; set; }
}