public static class User
{
    private static AppData _appData;

    public static AppData UserData
    {
        get { return _appData;}
        set { _appData = value; }
    }
    
    private static Goal _goalData;
    public static Goal GoalData
    {
        get { return _goalData; }
        set { _goalData = value; }
    }
    
    
}
