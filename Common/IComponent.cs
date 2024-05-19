namespace Common
{
    public interface IComponent
    {
        bool IsLicensed();
        void Execute();
    }
}
