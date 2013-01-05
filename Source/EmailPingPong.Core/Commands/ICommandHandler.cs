namespace EmailPingPong.Core.Commands
{
	public interface ICommandHandler<T>
		where T: ICommand
	{
		void Handle(T message);
	}
}