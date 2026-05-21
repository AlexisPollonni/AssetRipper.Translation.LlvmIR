using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fixed_point_sqrt_unsigned_long_Fract
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point4sqrtIDRmEENS_3cpp9enable_ifIXsr3cppE16is_fixed_point_vIT_EES4_E4typeES4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_fixed_point_v<unsigned long _Fract>, unsigned long _Fract>::type __llvm_libc_20_1_2_::fixed_point::sqrt<unsigned long _Fract>(unsigned long _Fract)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_fixed_point_v<unsigned long _Fract>, unsigned long _Fract>::type")]
	public unsafe static int Invoke([MangledName("x")][NativeType("unsigned long _Fract")] int X)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int x_frac = 0;
		int num7 = 0;
		int num8 = X;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Cpp_bit_cast_unsigned_int_unsigned_long_Fract.Invoke(&num8);
		int result;
		if (Details_expects_bool_condition_bool.Invoke(num == 0, Expected: false))
		{
			result = FXRep_unsigned_long_Fract_ZERO.Invoke();
		}
		else
		{
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = Cpp_countl_zero_unsigned_int.Invoke(num);
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = 32;
			Llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = -1;
			Llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = -1 - num2;
			Llvm_lifetime_start_p0.Invoke(4L, &num6);
			num6 = -2 - (num5 & -2);
			num <<= num6;
			Llvm_lifetime_start_p0.Invoke(4L, &x_frac);
			x_frac = Cpp_bit_cast_unsigned_long_Fract_unsigned_int.Invoke(&num);
			Llvm_lifetime_start_p0.Invoke(4L, &num7);
			num7 = Fixed_point_sqrt_core_fixed_point_internal_SqrtConfig_unsigned_long_Fract.Invoke(x_frac);
			num7 >>>= -1 - (num5 >> 1);
			result = Cpp_bit_cast_unsigned_long_Fract_unsigned_long_Fract.Invoke(&num7);
			Llvm_lifetime_end_p0.Invoke(4L, &num7);
			Llvm_lifetime_end_p0.Invoke(4L, &x_frac);
			Llvm_lifetime_end_p0.Invoke(4L, &num6);
			Llvm_lifetime_end_p0.Invoke(4L, &num5);
			Llvm_lifetime_end_p0.Invoke(4L, &num4);
			Llvm_lifetime_end_p0.Invoke(4L, &num3);
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
		}
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
