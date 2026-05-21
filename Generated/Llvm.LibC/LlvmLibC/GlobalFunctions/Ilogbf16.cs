using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Ilogbf16
{
	[MangledName("ilogbf16")]
	[DemangledName("ilogbf16")]
	public static int Invoke([MangledName("x")] Half X)
	{
		return Fputil_intlogb_int_Float16.Invoke(X);
	}
}
