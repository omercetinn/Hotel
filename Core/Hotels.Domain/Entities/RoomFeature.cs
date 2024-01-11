namespace Hotels.Domain.Entities
{
    public class RoomFeature
    {
        public int RoomFeatureId { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public int FeatureId { get; set; }
        public Feature Feature { get; set; }
        public bool Available { get; set; }        

    }
}
