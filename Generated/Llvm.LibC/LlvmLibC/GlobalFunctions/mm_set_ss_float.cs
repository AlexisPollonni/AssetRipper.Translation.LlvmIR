using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZL10_mm_set_ssf")]
[DemangledName("_mm_set_ss(float)")]
internal static partial class mm_set_ss_float
{
	public static InlineArray4_Single Invoke([MangledName("__w")] float w)
	{
		return default(InlineArray4_Single).InsertElement(w, 0).InsertElement(0f, 1).InsertElement(0f, 2)
			.InsertElement(0f, 3);
	}
}
