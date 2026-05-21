using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class F16sqrtf128
{
	[MangledName("f16sqrtf128")]
	[DemangledName("f16sqrtf128")]
	public static Half Invoke([MangledName("x")] double X)
	{
		return Fputil_sqrt_Float16_float128.Invoke(X);
	}
}
