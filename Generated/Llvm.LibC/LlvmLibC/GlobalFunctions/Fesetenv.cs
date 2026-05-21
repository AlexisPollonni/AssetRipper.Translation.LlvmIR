using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fesetenv
{
	[MangledName("fesetenv")]
	[DemangledName("fesetenv")]
	public unsafe static int Invoke([MangledName("envp")] void* Envp)
	{
		return Fputil_set_env.Invoke(Envp);
	}
}
