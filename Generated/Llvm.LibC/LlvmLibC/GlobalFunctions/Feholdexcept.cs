using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Feholdexcept
{
	[MangledName("feholdexcept")]
	[DemangledName("feholdexcept")]
	public unsafe static int Invoke([MangledName("envp")] void* Envp)
	{
		if (Fputil_get_env.Invoke(Envp) != 0)
		{
			return -1;
		}
		Fputil_clear_except.Invoke(61);
		Fputil_disable_except.Invoke(61);
		return 0;
	}
}
