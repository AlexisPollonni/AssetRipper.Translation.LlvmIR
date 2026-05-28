using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Div
{
	[MangledName("div")]
	[DemangledName("div")]
	public unsafe static long Invoke([MangledName("x")] int X, [MangledName("y")] int Y)
	{
		Internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up = default(Internal_ExpandedFloat_i7t5up);
		unchecked
		{
			*(int*)(&internal_ExpandedFloat_i7t5up) = -1431655766;
			((int*)(&internal_ExpandedFloat_i7t5up))[1] = -1431655766;
			Integer_rem_quo_int.Invoke(X, Y, &internal_ExpandedFloat_i7t5up.Mantissa, &internal_ExpandedFloat_i7t5up.Exponent);
			return *(long*)(&internal_ExpandedFloat_i7t5up);
		}
	}
}
