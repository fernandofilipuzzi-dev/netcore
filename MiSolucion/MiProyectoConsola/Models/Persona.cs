namespace MiProyectoConsola.Models
{
    public class Persona
    {
        public int DNI { get; set;}
        public string Nombre { get; set;}

        public override string ToString()
        {
            return $"{Nombre}({DNI})";
        }
    }
}