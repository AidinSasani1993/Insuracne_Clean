namespace QBimeh.Domain.Framework
{
    public interface IEntity<TKey>
    {
        public TKey Id { get; set; }
    }
}
