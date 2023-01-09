namespace AdapterPattern
{
    public interface IEnemyAttacker
    {
        void FireWeapon();
        void DriveForward();
        void AssignDriver(string DriverName);
    }
}