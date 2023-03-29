namespace stockfarmaciaBackend.Models
{
    public class Usuario
    {
        public String? Nombre { get; set; }
        public String? Apellido { get; set; }

        public Usuario(string? nombre, string? apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}
