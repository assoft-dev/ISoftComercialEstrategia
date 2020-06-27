namespace ISoftData.Models
{
    using ISoftComercialEstrategia.Enum;
    using System;

    [Serializable]
    public class FacturaModels
    {
        public int FacturaID { get; set; }
        public string FacturaNumero { get; set; }
        public decimal SubTotal { get; set; }
        public FacturaTypos FacturaTypos { get; set; }
        public ClientesModels ClientesModels { get; set; }
    }
}
