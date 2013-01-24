namespace EmailPingPong.Core.Commands
{
	public interface ICommandDispatcher
	{
		void Dispatch<T>(T command) where T : class, ICommand;
	}
}