using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Ispunct
{
	[MangledName("ispunct")]
	[DemangledName("ispunct")]
	public unsafe static int Invoke([MangledName("c")] int C)
	{
		int ch = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &ch);
		ch = C;
		bool result = !Internal_isalnum_kb8vgx.Invoke(ch) && Internal_isgraph_pxk4zv.Invoke(ch);
		Llvm_lifetime_end_p0.Invoke(4L, &ch);
		return result ? 1 : 0;
	}
}
