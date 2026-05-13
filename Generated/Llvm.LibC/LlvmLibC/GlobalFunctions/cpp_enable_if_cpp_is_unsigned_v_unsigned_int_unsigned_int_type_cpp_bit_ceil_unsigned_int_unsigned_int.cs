using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_ceilIjEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EES3_E4typeES3_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned int>, unsigned int>::type __llvm_libc_20_1_2_::cpp::bit_ceil<unsigned int>(unsigned int)")]
internal static partial class cpp_enable_if_cpp_is_unsigned_v_unsigned_int_unsigned_int_type_cpp_bit_ceil_unsigned_int_unsigned_int
{
	public static int Invoke(int value)
	{
		unchecked
		{
			if ((uint)value < 2u)
			{
				return 1;
			}
			return 1 << cpp_enable_if_cpp_is_unsigned_v_unsigned_int_int_type_cpp_bit_width_unsigned_int_unsigned_int.Invoke(value - 1);
		}
	}
}
