namespace Domain.Entities
{
    public class HotelPrice
    {
        public int HotelPriceId { get; set; }

        public int HotelId { get; set; }

        /// <summary>
        /// "Regular", "Reward"
        /// </summary>
        public string ClientType { get; set; }

        /// <summary>
        /// "Week", "Weekend"
        /// </summary>
        public string DateType { get; set; }

        public decimal Price { get; set; }

        public Hotel Hotel { get; set; }
    }
}