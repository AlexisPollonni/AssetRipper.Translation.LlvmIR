using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class F16subf128
{
	[MangledName("f16subf128")]
	[DemangledName("f16subf128")]
	public static Half Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Generic_sub_Float16_float128.Invoke(X, Y);
	}
}
