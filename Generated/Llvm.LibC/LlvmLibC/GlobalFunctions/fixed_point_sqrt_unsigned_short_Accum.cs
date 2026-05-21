using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fixed_point_sqrt_unsigned_short_Accum
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point4sqrtIDAtEENS_3cpp9enable_ifIXsr3cppE16is_fixed_point_vIT_EES4_E4typeES4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_fixed_point_v<unsigned short _Accum>, unsigned short _Accum>::type __llvm_libc_20_1_2_::fixed_point::sqrt<unsigned short _Accum>(unsigned short _Accum)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_fixed_point_v<unsigned short _Accum>, unsigned short _Accum>::type")]
	public unsafe static short Invoke([NativeType("unsigned short _Accum")] short x)
	{
		short num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		short x_frac = 0;
		short num7 = 0;
		short num8 = x;
		llvm_lifetime_start_p0.Invoke(2L, &num);
		num = cpp_bit_cast_unsigned_short_unsigned_short_Accum.Invoke(&num8);
		short result;
		if (details_expects_bool_condition_bool.Invoke(unchecked((ushort)num) == 0, expected: false))
		{
			result = FXRep_unsigned_short_Accum_ZERO.Invoke();
		}
		else
		{
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = cpp_countl_zero_unsigned_short.Invoke(num);
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = 16;
			llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = 7;
			llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = 7 - num2;
			llvm_lifetime_start_p0.Invoke(4L, &num6);
			num6 = 6 - (num5 & -2);
			unchecked
			{
				num = (short)((ushort)num << num6);
				llvm_lifetime_start_p0.Invoke(2L, &x_frac);
				x_frac = cpp_bit_cast_unsigned_Fract_unsigned_short.Invoke(&num);
				llvm_lifetime_start_p0.Invoke(2L, &num7);
				num7 = fixed_point_sqrt_core_fixed_point_internal_SqrtConfig_unsigned_short_Accum.Invoke(x_frac);
				num7 = (short)(num7 >>> (int)(short)checked(7 - (num5 >> 1)));
				result = cpp_bit_cast_unsigned_short_Accum_unsigned_Fract.Invoke(&num7);
				llvm_lifetime_end_p0.Invoke(2L, &num7);
				llvm_lifetime_end_p0.Invoke(2L, &x_frac);
				llvm_lifetime_end_p0.Invoke(4L, &num6);
				llvm_lifetime_end_p0.Invoke(4L, &num5);
				llvm_lifetime_end_p0.Invoke(4L, &num4);
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				llvm_lifetime_end_p0.Invoke(4L, &num2);
			}
		}
		llvm_lifetime_end_p0.Invoke(2L, &num);
		return result;
	}
}
