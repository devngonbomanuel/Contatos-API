using System.ComponentModel.DataAnnotations;

namespace src.models
{
    public class Contato
    {
        [Key]
        public Guid Id { get; private set; }

        public string NomeProprietario { get; private set; }

        public string EmailProprietario { get; private set; }
        public int TelemovelProprietario { get; private set; }
    }
}