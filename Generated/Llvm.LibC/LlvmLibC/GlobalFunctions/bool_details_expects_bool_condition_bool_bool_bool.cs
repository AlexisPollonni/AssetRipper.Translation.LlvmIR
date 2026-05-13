using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7details22expects_bool_conditionIbEEbT_S2_")]
[DemangledName("bool __llvm_libc_20_1_2_::details::expects_bool_condition<bool>(bool, bool)")]
internal static partial class bool_details_expects_bool_condition_bool_bool_bool
{
	public static bool Invoke(bool value, bool expected)
	{
		return llvm_expect_i64.Invoke((((value ? 1u : 0u) & 1u) == 1) ? 1L : 0L, (((expected ? 1u : 0u) & 1u) == 1) ? 1L : 0L) != 0L;
	}
}
