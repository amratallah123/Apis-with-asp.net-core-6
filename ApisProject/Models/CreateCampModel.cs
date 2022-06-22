using ApisProject.Data;

namespace ApisProject.Models
{
    public class CreateCampModel
    {
        public string Name { get; set; }
        public string Moniker { get; set; }
        public Location Location { get; set; }
    }
}
