using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fixed_point_sqrt_core_fixed_point_internal_SqrtConfig_unsigned_long_Fract
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point9sqrt_coreINS0_8internal10SqrtConfigIDRmEEEENT_4TypeES6_")]
	[DemangledName("__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned long _Fract>::Type __llvm_libc_20_1_2_::fixed_point::sqrt_core<__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned long _Fract>>(__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned long _Fract>::Type)")]
	[return: NativeType("__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned long _Fract>::Type")]
	public unsafe static int Invoke([MangledName("x_frac")][NativeType("__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned long _Fract>::Type")] int X_frac)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int a = 0;
		int num4 = 0;
		int num5 = 0;
		int i = 0;
		num = X_frac;
		int result;
		if (num == FXRep_unsigned_long_Fract_ONE_FOURTH.Invoke())
		{
			result = FXRep_unsigned_long_Fract_ONE_HALF.Invoke();
		}
		else
		{
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = Cpp_bit_cast_unsigned_int_unsigned_long_Fract.Invoke(&num);
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = (num2 >>> 28) - 4;
			Llvm_lifetime_start_p0.Invoke(4L, &a);
			long num6 = num3;
			unchecked
			{
				a = *(int*)((byte*)Fixed_point_internal_SqrtConfig_unsigned_long_Fract_FIRST_APPROX.Pointer + (nint)num6 * sizeof(InlineArray2_Int32));
				Llvm_lifetime_start_p0.Invoke(4L, &num4);
				long num7 = num3;
				num4 = ((int*)((byte*)Fixed_point_internal_SqrtConfig_unsigned_long_Fract_FIRST_APPROX.Pointer + (nint)num7 * sizeof(InlineArray2_Int32)))[1];
				Llvm_lifetime_start_p0.Invoke(4L, &num5);
				num5 = Llvm_umul_fix_i32.Invoke(a, num, 32) + num4;
				Llvm_lifetime_start_p0.Invoke(4L, &i);
				for (i = 0; i < 2; i = checked(i + 1))
				{
					num5 = (num5 >>> 1) + Llvm_udiv_fix_i32.Invoke(num >>> 1, num5, 32);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &i);
				result = num5;
				Llvm_lifetime_end_p0.Invoke(4L, &num5);
				Llvm_lifetime_end_p0.Invoke(4L, &num4);
				Llvm_lifetime_end_p0.Invoke(4L, &a);
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
				Llvm_lifetime_end_p0.Invoke(4L, &num2);
			}
		}
		return result;
	}
}
