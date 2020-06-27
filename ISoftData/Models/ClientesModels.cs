namespace ISoftData.Models
{
    using System;
    using System.Collections.Generic;

    [Serializable]
    public class ClientesModels
    {
        public int ClientesModelsID { get; set; }
        public string NomeCompleto { get; set; }
        public virtual ICollection<FacturaModels> FacturaModels { get; set; }
    }
}
