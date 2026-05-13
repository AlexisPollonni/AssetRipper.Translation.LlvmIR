using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Intrinsics.Unimplemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point9sqrt_coreINS0_8internal10SqrtConfigIDAtEEEENT_4TypeES6_")]
[DemangledName("__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned short _Accum>::Type __llvm_libc_20_1_2_::fixed_point::sqrt_core<__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned short _Accum>>(__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned short _Accum>::Type)")]
internal static partial class fixed_point_internal_SqrtConfig_unsigned_short_Accum_Type_fixed_point_sqrt_core_fixed_point_internal_SqrtConfig_unsigned_short_Accum_fixed_point_internal_SqrtConfig_unsigned_short_Accum_Type
{
	public unsafe static short Invoke(short x_frac)
	{
		short num = 0;
		short num2 = 0;
		int num3 = 0;
		short parameter_ = 0;
		short num4 = 0;
		short num5 = 0;
		int i = 0;
		num = x_frac;
		short result;
		if (num == fixed_point_FXRep_unsigned_Fract_ONE_FOURTH.Invoke())
		{
			result = fixed_point_FXRep_unsigned_Fract_ONE_HALF.Invoke();
		}
		else
		{
			llvm_lifetime_start_p0.Invoke(2L, &num2);
			num2 = cpp_enable_if_sizeof_unsigned_short_sizeof_unsigned_Fract_cpp_is_trivially_constructible_unsigned_short_value_cpp_is_trivially_copyable_unsigned_short_value_cpp_is_trivially_copyable_unsigned_Fract_value_unsigned_short_type_cpp_bit_cast_unsigned_short_unsigned_Fract_unsigned_Fract_const.Invoke(&num);
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = (unchecked((ushort)num2) >> 12) - 4;
			llvm_lifetime_start_p0.Invoke(2L, &parameter_);
			long num6 = num3;
			unchecked
			{
				parameter_ = *(short*)((byte*)fixed_point_internal_SqrtConfig_unsigned_Fract_FIRST_APPROX.Pointer + (nint)num6 * sizeof(InlineArray2_Int16));
				llvm_lifetime_start_p0.Invoke(2L, &num4);
				long num7 = num3;
				num4 = ((short*)((byte*)fixed_point_internal_SqrtConfig_unsigned_Fract_FIRST_APPROX.Pointer + (nint)num7 * sizeof(InlineArray2_Int16)))[1];
				llvm_lifetime_start_p0.Invoke(2L, &num5);
				num5 = (short)(llvm_umul_fix_i16.Invoke(parameter_, num, 16) + num4);
				llvm_lifetime_start_p0.Invoke(4L, &i);
				for (i = 0; i < 1; i = checked(i + 1))
				{
					num5 = (short)((num5 >>> 1) + llvm_udiv_fix_i16.Invoke((short)(num >>> 1), num5, 16));
				}
				llvm_lifetime_end_p0.Invoke(4L, &i);
				result = num5;
				llvm_lifetime_end_p0.Invoke(2L, &num5);
				llvm_lifetime_end_p0.Invoke(2L, &num4);
				llvm_lifetime_end_p0.Invoke(2L, &parameter_);
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				llvm_lifetime_end_p0.Invoke(2L, &num2);
			}
		}
		return result;
	}
}
