using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8popcountIjEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned int>, int>::type __llvm_libc_20_1_2_::cpp::popcount<unsigned int>(unsigned int)")]
internal static partial class cpp_enable_if_cpp_is_unsigned_v_unsigned_int_int_type_cpp_popcount_unsigned_int_unsigned_int
{
	public static int Invoke(int value)
	{
		return llvm_ctpop_i32.Invoke(value);
	}
}
