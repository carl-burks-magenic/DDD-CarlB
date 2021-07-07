namespace SharedKernel
{
    public class BasicWarehouseLocationInformation: ILocation
    {
        public string Aisle { get; }
        public int ShelfNumber { get; }

        public string LocationDescription => $"0-{Aisle}-{ShelfNumber}";
    }
}