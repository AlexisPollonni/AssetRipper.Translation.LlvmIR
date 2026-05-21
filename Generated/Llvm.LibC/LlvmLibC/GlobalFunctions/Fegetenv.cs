using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fegetenv
{
	[MangledName("fegetenv")]
	[DemangledName("fegetenv")]
	public unsafe static int Invoke([MangledName("envp")] void* Envp)
	{
		return Fputil_get_env.Invoke(Envp);
	}
}
