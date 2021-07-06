public enum ManagerStatus
{
    Shutdown,
    Initializing,
    Started
}
public interface IGameManager
{
    ManagerStatus status { get; }

    void Startup();

}
