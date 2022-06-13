class UserInformation
{
    private static UserInformation? LoggedInUser;

    public string Username, UserPassword;


    public UserInformation(string Username, string UserPassword)
    {
        this.Username = Username;
        this.UserPassword = UserPassword;
    }

    public static UserInformation GetLoggedInUser()
    {
        return LoggedInUser;
    }

    public static void SetLoggedInUser(UserInformation user)
    {
        LoggedInUser = user;
    }

    public static void ClearLoggedInUser()
    {
        LoggedInUser = null;
    }

}