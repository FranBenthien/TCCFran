using System;
using System.Collections.Generic;

namespace back.Model
{
    public partial class Formulario
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public string TypeHosting { get; set; } = null!;
        public string HostingAmount { get; set; } = null!;
        public string Accommodation { get; set; } = null!;
        public string? Link { get; set; }
        public string HostingComments { get; set; } = null!;
        public string Food { get; set; } = null!;
        public string FoodAmount { get; set; } = null!;
        public string TypeFood { get; set; } = null!;
        public string FoodPlaceName { get; set; } = null!;
        public string? LinkFood { get; set; }
        public string FoodComments { get; set; } = null!;
        public string TypeAttraction { get; set; } = null!;
        public string AttractionAmount { get; set; } = null!;
        public string TypeTransport { get; set; } = null!;
        public string AttractionComments { get; set; } = null!;

        public virtual Usuario? User { get; set; }
    }
}
