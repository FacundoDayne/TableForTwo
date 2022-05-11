class UserInformation
{
    private static UserInformation? LoggedInUser;

    public string UserEmail, UserPassword;


    public UserInformation(string UserEmail, string UserPassword)
    {
        this.UserEmail = UserEmail;
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

}