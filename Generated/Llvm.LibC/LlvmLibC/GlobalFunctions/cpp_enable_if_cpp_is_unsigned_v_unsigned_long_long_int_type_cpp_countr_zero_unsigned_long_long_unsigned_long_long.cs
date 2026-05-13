using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp11countr_zeroIyEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned long long>, int>::type __llvm_libc_20_1_2_::cpp::countr_zero<unsigned long long>(unsigned long long)")]
internal static partial class cpp_enable_if_cpp_is_unsigned_v_unsigned_long_long_int_type_cpp_countr_zero_unsigned_long_long_unsigned_long_long
{
	public static int Invoke(long value)
	{
		return InstructionHelper.Select(value == 0L, 64, unchecked((int)llvm_cttz_i64.Invoke(value, parameter_1: true)));
	}
}
