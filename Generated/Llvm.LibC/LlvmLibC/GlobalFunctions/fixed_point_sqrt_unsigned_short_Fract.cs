using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fixed_point_sqrt_unsigned_short_Fract
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point4sqrtIDRtEENS_3cpp9enable_ifIXsr3cppE16is_fixed_point_vIT_EES4_E4typeES4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_fixed_point_v<unsigned short _Fract>, unsigned short _Fract>::type __llvm_libc_20_1_2_::fixed_point::sqrt<unsigned short _Fract>(unsigned short _Fract)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_fixed_point_v<unsigned short _Fract>, unsigned short _Fract>::type")]
	public unsafe static sbyte Invoke([NativeType("unsigned short _Fract")] sbyte x)
	{
		sbyte b = 0;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		sbyte x_frac = 0;
		sbyte b2 = 0;
		sbyte b3 = x;
		llvm_lifetime_start_p0.Invoke(1L, &b);
		b = cpp_bit_cast_unsigned_char_unsigned_short_Fract.Invoke(&b3);
		sbyte result;
		if (details_expects_bool_condition_bool.Invoke(unchecked((byte)b) == 0, expected: false))
		{
			result = FXRep_unsigned_short_Fract_ZERO.Invoke();
		}
		else
		{
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = cpp_countl_zero_unsigned_char.Invoke(b);
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = 8;
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = -1;
			llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = -1 - num;
			llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = -2 - (num4 & -2);
			unchecked
			{
				b = (sbyte)((byte)b << num5);
				llvm_lifetime_start_p0.Invoke(1L, &x_frac);
				x_frac = cpp_bit_cast_unsigned_short_Fract_unsigned_char.Invoke(&b);
				llvm_lifetime_start_p0.Invoke(1L, &b2);
				b2 = fixed_point_sqrt_core_fixed_point_internal_SqrtConfig_unsigned_short_Fract.Invoke(x_frac);
				b2 = (sbyte)(b2 >>> (int)(sbyte)checked(-1 - (num4 >> 1)));
				result = cpp_bit_cast_unsigned_short_Fract_unsigned_short_Fract.Invoke(&b2);
				llvm_lifetime_end_p0.Invoke(1L, &b2);
				llvm_lifetime_end_p0.Invoke(1L, &x_frac);
				llvm_lifetime_end_p0.Invoke(4L, &num5);
				llvm_lifetime_end_p0.Invoke(4L, &num4);
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				llvm_lifetime_end_p0.Invoke(4L, &num2);
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
		}
		llvm_lifetime_end_p0.Invoke(1L, &b);
		return result;
	}
}
