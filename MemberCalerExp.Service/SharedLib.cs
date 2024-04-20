namespace MemberCalerExp.Service;

public class SharedLib
{
    public static string WhosCalling(
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0
        )
    {
        CallerInfo ci = new(
            memberName,
            sourceFilePath,
            sourceLineNumber);
        return ci.ToString();
    }

}
