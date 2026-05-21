using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fesetexcept
{
	[MangledName("fesetexcept")]
	[DemangledName("fesetexcept")]
	public static int Invoke([MangledName("excepts")] int Excepts)
	{
		return Fputil_set_except.Invoke(Excepts);
	}
}
