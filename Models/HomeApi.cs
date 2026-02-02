namespace HomeApi.Models
{
    public class Home
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string House { get; set; } = string.Empty;
        public string Town { get; set; } = string.Empty;
        public int Price { get; set; }
        public string Bed { get; set; } = string.Empty;
        public int Bath { get; set; }
        public string SaleStatus { get; set; } = string.Empty;
        public string Distance { get; set; } = string.Empty;
        public string PosterImageName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
