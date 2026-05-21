using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class F16subf
{
	[MangledName("f16subf")]
	[DemangledName("f16subf")]
	public static Half Invoke([MangledName("x")] float X, [MangledName("y")] float Y)
	{
		return Generic_sub_Float16_float.Invoke(X, Y);
	}
}
