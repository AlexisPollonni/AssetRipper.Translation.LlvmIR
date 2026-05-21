using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Feupdateenv
{
	[MangledName("feupdateenv")]
	[DemangledName("feupdateenv")]
	public unsafe static int Invoke([MangledName("envp")] void* Envp)
	{
		int excepts = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &excepts);
		excepts = Fputil_test_except.Invoke(61);
		int result = ((Fputil_set_env.Invoke(Envp) == 0) ? Fputil_raise_except.Invoke(excepts) : (-1));
		Llvm_lifetime_end_p0.Invoke(4L, &excepts);
		return result;
	}
}
