var user = new User();
var testuser = await user.GetUserNameAsync(1);
Console.WriteLine(testuser);