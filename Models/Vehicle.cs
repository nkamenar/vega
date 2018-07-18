using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace vega.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
        public bool IsRegistered { get; set; }
        public Contact Contact { get; set; } = new Contact();
        public DateTime LastUpdated { get; set; }
        public ICollection<VehicleFeature> Features { get; set; } = new Collection<VehicleFeature>();
    }
}