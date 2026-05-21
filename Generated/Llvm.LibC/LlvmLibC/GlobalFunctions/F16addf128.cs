using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class F16addf128
{
	[MangledName("f16addf128")]
	[DemangledName("f16addf128")]
	public static Half Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Generic_add_Float16_float128.Invoke(X, Y);
	}
}
