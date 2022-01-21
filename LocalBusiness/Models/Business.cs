namespace LocalBusiness.Models
{
    public class Business
    {
        public int BusinessId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string Review {get; set; }
        public int Rating {get; set; }
    }
}