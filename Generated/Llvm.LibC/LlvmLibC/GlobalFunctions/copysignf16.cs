using System;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class copysignf16
{
	public static Half Invoke(Half x, Half y)
	{
		return llvm_copysign_f16.Invoke(x, y);
	}
}
