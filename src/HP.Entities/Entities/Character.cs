using System;

namespace HP.Entities.Entities
{
    public class Character
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Species { get; set; } = string.Empty;
        public string House {get;set;} = string.Empty;
        public string Wizard {get;set;} = string.Empty;
        public string Ancestry {get;set;} = string.Empty;
        public string Patronus {get;set;} = string.Empty;
        public string Actor {get;set;} = string.Empty;
        public bool Alive {get;set;} = true;
        public string Image {get;set;} = string.Empty;
    }   
}