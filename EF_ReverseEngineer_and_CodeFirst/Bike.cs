namespace EF_ReverseEngineer_and_CodeFirst
{
    public class Bike
    {
        public int Id { get; set; }
        public string? Modelo { get; set; }
        public decimal Valor { get; set; }
        public bool? Garantia { get; set; }
        public string? Comentarios { get; set; }
        public string? Tipo { get; set; }
    }
}
