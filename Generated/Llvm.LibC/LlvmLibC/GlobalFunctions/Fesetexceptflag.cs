using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fesetexceptflag
{
	[MangledName("fesetexceptflag")]
	[DemangledName("fesetexceptflag")]
	public unsafe static int Invoke([MangledName("flagp")] void* Flagp, [MangledName("excepts")] int Excepts)
	{
		int excepts = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &excepts);
		excepts = unchecked((ushort)(*(short*)Flagp)) & Excepts;
		Fputil_clear_except.Invoke(61);
		int result = Fputil_set_except.Invoke(excepts);
		Llvm_lifetime_end_p0.Invoke(4L, &excepts);
		return result;
	}
}
