using System;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class remainderf16
{
	public unsafe static Half Invoke(Half x, Half y)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = -1431655766;
		Half result = fputil_remquo_Float16_0.Invoke(x, y, &num);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
