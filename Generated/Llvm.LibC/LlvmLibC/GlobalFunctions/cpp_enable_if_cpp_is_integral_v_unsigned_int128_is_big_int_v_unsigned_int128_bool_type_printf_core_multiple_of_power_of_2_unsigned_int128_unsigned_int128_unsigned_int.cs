using System;
using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core22multiple_of_power_of_2IoEENS_3cpp9enable_ifIXoosr3cppE13is_integral_vIT_E12is_big_int_vIS4_EEbE4typeES4_j")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<unsigned __int128> || is_big_int_v<unsigned __int128>, bool>::type __llvm_libc_20_1_2_::printf_core::multiple_of_power_of_2<unsigned __int128>(unsigned __int128, unsigned int)")]
internal static partial class cpp_enable_if_cpp_is_integral_v_unsigned_int128_is_big_int_v_unsigned_int128_bool_type_printf_core_multiple_of_power_of_2_unsigned_int128_unsigned_int128_unsigned_int
{
	public unsafe static bool Invoke([MangledName("value.coerce0")] long value, [MangledName("value.coerce1")][CleanName("p")] long p_rwsa4c, [MangledName("p")][CleanName("p")] int p_42n5rb)
	{
		Int128 x = default(Int128);
		unchecked
		{
			*(long*)(&x) = value;
			((long*)(&x))[1] = p_rwsa4c;
			return NumericHelper.IntCmpEq(NumericHelper.BitwiseAnd(x, NumericHelper.Subtract(NumericHelper.ShiftLeft(y: (Int128)(UInt128)(uint)p_42n5rb, x: 1L), 1L)), 0L);
		}
	}
}
