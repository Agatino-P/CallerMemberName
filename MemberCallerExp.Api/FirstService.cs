using MemberCalerExp.Service;

namespace MemberCallerExp.Api;

public class FirstService
{
    public static string CallIt() {
        return SharedLib.WhosCalling();
    }
}
