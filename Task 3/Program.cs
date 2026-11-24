UserAccount userAccount = new UserAccount()
{
    UserName = "Yusuf"
};
userAccount.Login();
userAccount.PostStory();

System.Console.WriteLine();

BusinessAccount businessAccount = new BusinessAccount()
{
    UserName = "Idris Shop"
};
businessAccount.Login();
businessAccount.ViewAnalytics();