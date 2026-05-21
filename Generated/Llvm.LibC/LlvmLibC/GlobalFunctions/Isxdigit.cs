using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Isxdigit
{
	[MangledName("isxdigit")]
	[DemangledName("isxdigit")]
	public unsafe static int Invoke([MangledName("c")] int C)
	{
		int ch = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &ch);
		ch = C;
		bool result = Internal_isalnum_59ka7f.Invoke(ch) && Internal_b36_char_to_int_whaa9c.Invoke(ch) < 16;
		Llvm_lifetime_end_p0.Invoke(4L, &ch);
		return result ? 1 : 0;
	}
}
