using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp11countr_zeroItEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned short>, int>::type __llvm_libc_20_1_2_::cpp::countr_zero<unsigned short>(unsigned short)")]
internal static partial class cpp_enable_if_cpp_is_unsigned_v_unsigned_short_int_type_cpp_countr_zero_unsigned_short_unsigned_short
{
	public static int Invoke(short value)
	{
		short num = value;
		return InstructionHelper.Select(num == 0, 16, unchecked((ushort)llvm_cttz_i16.Invoke(num, parameter_1: true)));
	}
}
