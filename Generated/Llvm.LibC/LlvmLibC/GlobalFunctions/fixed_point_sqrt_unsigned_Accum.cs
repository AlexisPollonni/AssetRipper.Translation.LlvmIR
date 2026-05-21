using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fixed_point_sqrt_unsigned_Accum
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point4sqrtIDAjEENS_3cpp9enable_ifIXsr3cppE16is_fixed_point_vIT_EES4_E4typeES4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_fixed_point_v<unsigned _Accum>, unsigned _Accum>::type __llvm_libc_20_1_2_::fixed_point::sqrt<unsigned _Accum>(unsigned _Accum)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_fixed_point_v<unsigned _Accum>, unsigned _Accum>::type")]
	public unsafe static int Invoke([NativeType("unsigned _Accum")] int x)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int x_frac = 0;
		int num7 = 0;
		int num8 = x;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = cpp_bit_cast_unsigned_int_unsigned_Accum.Invoke(&num8);
		int result;
		if (details_expects_bool_condition_bool.Invoke(num == 0, expected: false))
		{
			result = FXRep_unsigned_Accum_ZERO.Invoke();
		}
		else
		{
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = cpp_countl_zero_unsigned_int.Invoke(num);
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = 32;
			llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = 15;
			llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = 15 - num2;
			llvm_lifetime_start_p0.Invoke(4L, &num6);
			num6 = 14 - (num5 & -2);
			num <<= num6;
			llvm_lifetime_start_p0.Invoke(4L, &x_frac);
			x_frac = cpp_bit_cast_unsigned_long_Fract_unsigned_int.Invoke(&num);
			llvm_lifetime_start_p0.Invoke(4L, &num7);
			num7 = fixed_point_sqrt_core_fixed_point_internal_SqrtConfig_unsigned_Accum.Invoke(x_frac);
			num7 >>>= 15 - (num5 >> 1);
			result = cpp_bit_cast_unsigned_Accum_unsigned_long_Fract.Invoke(&num7);
			llvm_lifetime_end_p0.Invoke(4L, &num7);
			llvm_lifetime_end_p0.Invoke(4L, &x_frac);
			llvm_lifetime_end_p0.Invoke(4L, &num6);
			llvm_lifetime_end_p0.Invoke(4L, &num5);
			llvm_lifetime_end_p0.Invoke(4L, &num4);
			llvm_lifetime_end_p0.Invoke(4L, &num3);
			llvm_lifetime_end_p0.Invoke(4L, &num2);
		}
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
