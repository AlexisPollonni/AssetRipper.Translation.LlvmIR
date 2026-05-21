using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Enumerations;

[MangledName("_ZTSSt17float_round_style")]
[DemangledName("std::float_round_style")]
public enum Float_round_style
{
	round_indeterminate = -1,
	round_toward_zero,
	round_to_nearest,
	round_toward_infinity,
	round_toward_neg_infinity
}
