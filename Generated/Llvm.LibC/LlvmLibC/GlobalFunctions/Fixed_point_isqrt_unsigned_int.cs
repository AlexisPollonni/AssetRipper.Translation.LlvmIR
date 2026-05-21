using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fixed_point_isqrt_unsigned_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point5isqrtIjEENS0_8internal10SqrtConfigIT_E7OutTypeES4_")]
	[DemangledName("__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned int>::OutType __llvm_libc_20_1_2_::fixed_point::isqrt<unsigned int>(unsigned int)")]
	[return: NativeType("__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned int>::OutType")]
	public unsafe static int Invoke([MangledName("x")][NativeType("unsigned int")] int X)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int x_frac = 0;
		int num4 = 0;
		num = X;
		int result;
		if (num == 0)
		{
			result = FXRep_unsigned_Accum_ZERO.Invoke();
		}
		else
		{
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = Cpp_countl_zero_unsigned_int.Invoke(num);
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = num2 >> 1 << 1;
			num <<= num3;
			Llvm_lifetime_start_p0.Invoke(4L, &x_frac);
			x_frac = Cpp_bit_cast_unsigned_long_Fract_unsigned_int.Invoke(&num);
			Llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = Fixed_point_sqrt_core_fixed_point_internal_SqrtConfig_unsigned_long_Fract.Invoke(x_frac);
			num4 >>>= num3 >> 1;
			result = Cpp_bit_cast_unsigned_Accum_unsigned_long_Fract.Invoke(&num4);
			Llvm_lifetime_end_p0.Invoke(4L, &num4);
			Llvm_lifetime_end_p0.Invoke(4L, &x_frac);
			Llvm_lifetime_end_p0.Invoke(4L, &num3);
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
		}
		return result;
	}
}
