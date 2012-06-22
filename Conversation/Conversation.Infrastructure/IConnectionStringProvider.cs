namespace EmailPingPong.Infrastructure
{
	public interface IConnectionStringProvider
	{
		string ConnectionString { get; }
	}
}