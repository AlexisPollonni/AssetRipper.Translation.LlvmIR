using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fixed_point_isqrt_unsigned_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point5isqrtIjEENS0_8internal10SqrtConfigIT_E7OutTypeES4_")]
	[DemangledName("__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned int>::OutType __llvm_libc_20_1_2_::fixed_point::isqrt<unsigned int>(unsigned int)")]
	[return: NativeType("__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned int>::OutType")]
	public unsafe static int Invoke([NativeType("unsigned int")] int x)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int x_frac = 0;
		int num4 = 0;
		num = x;
		int result;
		if (num == 0)
		{
			result = FXRep_unsigned_Accum_ZERO.Invoke();
		}
		else
		{
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = cpp_countl_zero_unsigned_int.Invoke(num);
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = num2 >> 1 << 1;
			num <<= num3;
			llvm_lifetime_start_p0.Invoke(4L, &x_frac);
			x_frac = cpp_bit_cast_unsigned_long_Fract_unsigned_int.Invoke(&num);
			llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = fixed_point_sqrt_core_fixed_point_internal_SqrtConfig_unsigned_long_Fract.Invoke(x_frac);
			num4 >>>= num3 >> 1;
			result = cpp_bit_cast_unsigned_Accum_unsigned_long_Fract.Invoke(&num4);
			llvm_lifetime_end_p0.Invoke(4L, &num4);
			llvm_lifetime_end_p0.Invoke(4L, &x_frac);
			llvm_lifetime_end_p0.Invoke(4L, &num3);
			llvm_lifetime_end_p0.Invoke(4L, &num2);
		}
		return result;
	}
}
