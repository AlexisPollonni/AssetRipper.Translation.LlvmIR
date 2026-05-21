using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FXRep_short_Fract_MIN
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point5FXRepIDRsE3MINEv")]
	[DemangledName("__llvm_libc_20_1_2_::fixed_point::FXRep<short _Fract>::MIN()")]
	public static sbyte Invoke()
	{
		return sbyte.MinValue;
	}
}
