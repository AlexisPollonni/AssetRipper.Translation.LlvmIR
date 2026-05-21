using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fixed_point_isqrt_unsigned_short
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point5isqrtItEENS0_8internal10SqrtConfigIT_E7OutTypeES4_")]
	[DemangledName("__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned short>::OutType __llvm_libc_20_1_2_::fixed_point::isqrt<unsigned short>(unsigned short)")]
	[return: NativeType("__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned short>::OutType")]
	public unsafe static short Invoke([NativeType("unsigned short")] short x)
	{
		short num = 0;
		int num2 = 0;
		int num3 = 0;
		short x_frac = 0;
		short num4 = 0;
		num = x;
		unchecked
		{
			short result;
			if ((ushort)num == 0)
			{
				result = FXRep_unsigned_short_Accum_ZERO.Invoke();
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = cpp_countl_zero_unsigned_short.Invoke(num);
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = num2 >> 1 << 1;
				num = (short)((ushort)num << num3);
				llvm_lifetime_start_p0.Invoke(2L, &x_frac);
				x_frac = cpp_bit_cast_unsigned_Fract_unsigned_short.Invoke(&num);
				llvm_lifetime_start_p0.Invoke(2L, &num4);
				num4 = fixed_point_sqrt_core_fixed_point_internal_SqrtConfig_unsigned_Fract.Invoke(x_frac);
				num4 = (short)(num4 >>> (int)(short)(num3 >> 1));
				result = cpp_bit_cast_unsigned_short_Accum_unsigned_Fract.Invoke(&num4);
				llvm_lifetime_end_p0.Invoke(2L, &num4);
				llvm_lifetime_end_p0.Invoke(2L, &x_frac);
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				llvm_lifetime_end_p0.Invoke(4L, &num2);
			}
			return result;
		}
	}
}
