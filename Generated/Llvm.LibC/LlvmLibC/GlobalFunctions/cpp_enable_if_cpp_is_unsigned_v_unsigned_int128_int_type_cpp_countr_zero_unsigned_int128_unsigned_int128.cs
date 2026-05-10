using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp11countr_zeroIoEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned __int128>, int>::type __llvm_libc_20_1_2_::cpp::countr_zero<unsigned __int128>(unsigned __int128)")]
internal static partial class cpp_enable_if_cpp_is_unsigned_v_unsigned_int128_int_type_cpp_countr_zero_unsigned_int128_unsigned_int128
{
	public unsafe static int Invoke([MangledName("value.coerce0")] long value, [MangledName("value.coerce1")] long value_coerce1)
	{
		Int128 @int = default(Int128);
		unchecked
		{
			*(long*)(&@int) = value;
			((long*)(&@int))[1] = value_coerce1;
			Int128 int2 = @int;
			return InstructionHelper.Select(falseValue: (int)llvm_cttz_i128.Invoke(int2, parameter_1: true), condition: NumericHelper.IntCmpEq(int2, 0L), trueValue: 128);
		}
	}
}
