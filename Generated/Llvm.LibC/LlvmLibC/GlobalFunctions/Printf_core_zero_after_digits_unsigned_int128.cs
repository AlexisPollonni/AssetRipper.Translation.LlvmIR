using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Printf_core_zero_after_digits_unsigned_int128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core17zero_after_digitsIoEENS_3cpp9enable_ifIXoosr3cppE13is_integral_vIT_E12is_big_int_vIS4_EEbE4typeEiiS4_i")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<unsigned __int128> || is_big_int_v<unsigned __int128>, bool>::type __llvm_libc_20_1_2_::printf_core::zero_after_digits<unsigned __int128>(int, int, unsigned __int128, int)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<unsigned __int128> || is_big_int_v<unsigned __int128>, bool>::type")]
	public unsafe static bool Invoke([MangledName("base_2_exp")] int Base_2_exp, [MangledName("digits_after_point")][NativeType("int")] int Digits_after_point, [MangledName("mantissa.coerce0")][NativeType("int")] long Mantissa, [MangledName("mantissa.coerce1")][NativeType("unsigned __int128")] long Mant_width, [MangledName("mant_width")][NativeType("int")] int Required_twos)
	{
		Int128 @int = default(Int128);
		int num = 0;
		sbyte b = 0;
		Int128 int2 = default(Int128);
		unchecked
		{
			*(long*)(&@int) = Mantissa;
			((long*)(&@int))[1] = Mant_width;
			Int128 int3 = @int;
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = checked(-Base_2_exp - Digits_after_point - 1);
			Llvm_lifetime_start_p0.Invoke(1L, &b);
			int num2;
			if (num <= 0)
			{
				num2 = 1;
			}
			else if (num >= checked(Required_twos + 8))
			{
				num2 = 0;
			}
			else
			{
				int p_42n5rb = num;
				int2 = int3;
				num2 = (Printf_core_multiple_of_power_of_2_unsigned_int128.Invoke(*(long*)(&int2), ((long*)(&int2))[1], p_42n5rb) ? 1 : 0);
			}
			b = (sbyte)(byte)num2;
			bool result = (b & 1) == 1;
			Llvm_lifetime_end_p0.Invoke(1L, &b);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
