namespace SharedKernel
{
    public interface IEntity<TIdentifier>
    {
        public TIdentifier Id { get;  }
    }
}