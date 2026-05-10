using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp11countr_zeroIhEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned char>, int>::type __llvm_libc_20_1_2_::cpp::countr_zero<unsigned char>(unsigned char)")]
internal static partial class cpp_enable_if_cpp_is_unsigned_v_unsigned_char_int_type_cpp_countr_zero_unsigned_char_unsigned_char
{
	public static int Invoke(sbyte value)
	{
		sbyte b = value;
		return InstructionHelper.Select(b == 0, 8, unchecked((byte)llvm_cttz_i8.Invoke(b, parameter_1: true)));
	}
}
