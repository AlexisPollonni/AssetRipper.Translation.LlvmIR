using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZL10_mm_set_sdd")]
[DemangledName("_mm_set_sd(double)")]
internal static partial class mm_set_sd_double
{
	public static InlineArray2_Double Invoke([MangledName("__w")] double w)
	{
		return default(InlineArray2_Double).InsertElement(w, 0).InsertElement(0.0, 1);
	}
}
