namespace TestSite.Shared
{
    public class StorageLocation
    {
        public string Name { get; set; }
        public StorageType StorageType { get; set; }
        public string Description { get; set; }
    }


    public enum StorageType
    {
        Location,
        None, 
        Replen
    }
}
