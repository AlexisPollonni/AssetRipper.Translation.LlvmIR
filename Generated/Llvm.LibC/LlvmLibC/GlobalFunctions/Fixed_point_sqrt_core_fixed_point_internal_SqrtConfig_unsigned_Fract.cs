using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fixed_point_sqrt_core_fixed_point_internal_SqrtConfig_unsigned_Fract
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point9sqrt_coreINS0_8internal10SqrtConfigIDRjEEEENT_4TypeES6_")]
	[DemangledName("__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned _Fract>::Type __llvm_libc_20_1_2_::fixed_point::sqrt_core<__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned _Fract>>(__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned _Fract>::Type)")]
	[return: NativeType("__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned _Fract>::Type")]
	public unsafe static short Invoke([MangledName("x_frac")][NativeType("__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned _Fract>::Type")] short X_frac)
	{
		short num = 0;
		short num2 = 0;
		int num3 = 0;
		short a = 0;
		short num4 = 0;
		short num5 = 0;
		int i = 0;
		num = X_frac;
		short result;
		if (num == FXRep_unsigned_Fract_ONE_FOURTH.Invoke())
		{
			result = FXRep_unsigned_Fract_ONE_HALF.Invoke();
		}
		else
		{
			Llvm_lifetime_start_p0.Invoke(2L, &num2);
			num2 = Cpp_bit_cast_unsigned_short_unsigned_Fract.Invoke(&num);
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = (unchecked((ushort)num2) >> 12) - 4;
			Llvm_lifetime_start_p0.Invoke(2L, &a);
			long num6 = num3;
			unchecked
			{
				a = *(short*)((byte*)Fixed_point_internal_SqrtConfig_unsigned_Fract_FIRST_APPROX.Pointer + (nint)num6 * sizeof(InlineArray2_Int16));
				Llvm_lifetime_start_p0.Invoke(2L, &num4);
				long num7 = num3;
				num4 = ((short*)((byte*)Fixed_point_internal_SqrtConfig_unsigned_Fract_FIRST_APPROX.Pointer + (nint)num7 * sizeof(InlineArray2_Int16)))[1];
				Llvm_lifetime_start_p0.Invoke(2L, &num5);
				num5 = (short)(Llvm_umul_fix_i16.Invoke(a, num, 16) + num4);
				Llvm_lifetime_start_p0.Invoke(4L, &i);
				for (i = 0; i < 1; i = checked(i + 1))
				{
					num5 = (short)((num5 >>> 1) + Llvm_udiv_fix_i16.Invoke((short)(num >>> 1), num5, 16));
				}
				Llvm_lifetime_end_p0.Invoke(4L, &i);
				result = num5;
				Llvm_lifetime_end_p0.Invoke(2L, &num5);
				Llvm_lifetime_end_p0.Invoke(2L, &num4);
				Llvm_lifetime_end_p0.Invoke(2L, &a);
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
				Llvm_lifetime_end_p0.Invoke(2L, &num2);
			}
		}
		return result;
	}
}
