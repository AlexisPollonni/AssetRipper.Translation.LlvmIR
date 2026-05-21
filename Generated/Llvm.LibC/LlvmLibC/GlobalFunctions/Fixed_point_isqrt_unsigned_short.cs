using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fixed_point_isqrt_unsigned_short
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point5isqrtItEENS0_8internal10SqrtConfigIT_E7OutTypeES4_")]
	[DemangledName("__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned short>::OutType __llvm_libc_20_1_2_::fixed_point::isqrt<unsigned short>(unsigned short)")]
	[return: NativeType("__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned short>::OutType")]
	public unsafe static short Invoke([MangledName("x")][NativeType("unsigned short")] short X)
	{
		short num = 0;
		int num2 = 0;
		int num3 = 0;
		short x_frac = 0;
		short num4 = 0;
		num = X;
		unchecked
		{
			short result;
			if ((ushort)num == 0)
			{
				result = FXRep_unsigned_short_Accum_ZERO.Invoke();
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = Cpp_countl_zero_unsigned_short.Invoke(num);
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = num2 >> 1 << 1;
				num = (short)((ushort)num << num3);
				Llvm_lifetime_start_p0.Invoke(2L, &x_frac);
				x_frac = Cpp_bit_cast_unsigned_Fract_unsigned_short.Invoke(&num);
				Llvm_lifetime_start_p0.Invoke(2L, &num4);
				num4 = Fixed_point_sqrt_core_fixed_point_internal_SqrtConfig_unsigned_Fract.Invoke(x_frac);
				num4 = (short)(num4 >>> (int)(short)(num3 >> 1));
				result = Cpp_bit_cast_unsigned_short_Accum_unsigned_Fract.Invoke(&num4);
				Llvm_lifetime_end_p0.Invoke(2L, &num4);
				Llvm_lifetime_end_p0.Invoke(2L, &x_frac);
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
				Llvm_lifetime_end_p0.Invoke(4L, &num2);
			}
			return result;
		}
	}
}
