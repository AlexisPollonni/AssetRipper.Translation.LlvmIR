using System;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class iscanonicalf16
{
	public unsafe static int Invoke(Half x)
	{
		Half half = default(Half);
		Half half2 = x;
		llvm_lifetime_start_p0.Invoke(2L, &half);
		half = default(Half);
		bool result = fputil_canonicalize_Float16_0.Invoke(&half, &half2) == 0;
		llvm_lifetime_end_p0.Invoke(2L, &half);
		return result ? 1 : 0;
	}
}
