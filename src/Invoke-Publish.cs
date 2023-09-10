using System.Management.Automation;
using Dgmjr.PowerShell.Enums;

namespace Dgmjr.PowerShell;

[Cmdlet("Publish", "Project", DefaultParameterSetName = "Build")]
[Alias(new string[] { "publish" })]
public class Publish : InvokeBuild
{
    public override DotnetCommand Command
    {
        get => DotnetCommand.publish;
        set { }
    }
}
