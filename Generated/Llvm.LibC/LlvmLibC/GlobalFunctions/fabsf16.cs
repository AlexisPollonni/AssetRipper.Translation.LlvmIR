using System;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fabsf16
{
	public static Half Invoke(Half x)
	{
		return llvm_fabs_f16.Invoke(x);
	}
}
