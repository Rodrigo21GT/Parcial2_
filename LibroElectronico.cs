namespace Parcial2_
{
    public class LibroElectronico : Libro
    {
		public string Formato { get; set; }
        public string Tamaniuo { get; set; }
        public LibroElectronico()
        {
            Formato = string.Empty;
            Tamaniuo = string.Empty;

        }
    }
}
