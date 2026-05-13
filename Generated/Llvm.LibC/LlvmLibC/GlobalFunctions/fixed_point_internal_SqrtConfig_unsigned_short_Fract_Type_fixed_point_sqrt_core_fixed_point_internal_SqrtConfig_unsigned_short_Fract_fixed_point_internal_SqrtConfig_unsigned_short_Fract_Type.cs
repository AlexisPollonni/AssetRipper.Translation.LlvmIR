using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Intrinsics.Unimplemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point9sqrt_coreINS0_8internal10SqrtConfigIDRtEEEENT_4TypeES6_")]
[DemangledName("__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned short _Fract>::Type __llvm_libc_20_1_2_::fixed_point::sqrt_core<__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned short _Fract>>(__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned short _Fract>::Type)")]
internal static partial class fixed_point_internal_SqrtConfig_unsigned_short_Fract_Type_fixed_point_sqrt_core_fixed_point_internal_SqrtConfig_unsigned_short_Fract_fixed_point_internal_SqrtConfig_unsigned_short_Fract_Type
{
	public unsafe static sbyte Invoke(sbyte x_frac)
	{
		sbyte b = 0;
		sbyte b2 = 0;
		int num = 0;
		sbyte parameter_ = 0;
		sbyte b3 = 0;
		sbyte b4 = 0;
		int i = 0;
		b = x_frac;
		sbyte result;
		if (b == fixed_point_FXRep_unsigned_short_Fract_ONE_FOURTH.Invoke())
		{
			result = fixed_point_FXRep_unsigned_short_Fract_ONE_HALF.Invoke();
		}
		else
		{
			llvm_lifetime_start_p0.Invoke(1L, &b2);
			b2 = cpp_enable_if_sizeof_unsigned_char_sizeof_unsigned_short_Fract_cpp_is_trivially_constructible_unsigned_char_value_cpp_is_trivially_copyable_unsigned_char_value_cpp_is_trivially_copyable_unsigned_short_Fract_value_unsigned_char_type_cpp_bit_cast_unsigned_char_unsigned_short_Fract_unsigned_short_Fract_const.Invoke(&b);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = (unchecked((byte)b2) >> 4) - 4;
			llvm_lifetime_start_p0.Invoke(1L, &parameter_);
			long num2 = num;
			unchecked
			{
				parameter_ = ((sbyte*)fixed_point_internal_SqrtConfig_unsigned_short_Fract_FIRST_APPROX.Pointer)[(nint)num2 * sizeof(InlineArray2_SByte)];
				llvm_lifetime_start_p0.Invoke(1L, &b3);
				long num3 = num;
				b3 = (sbyte)((byte*)fixed_point_internal_SqrtConfig_unsigned_short_Fract_FIRST_APPROX.Pointer + (nint)num3 * sizeof(InlineArray2_SByte))[1];
				llvm_lifetime_start_p0.Invoke(1L, &b4);
				b4 = (sbyte)(llvm_umul_fix_i8.Invoke(parameter_, b, 8) + b3);
				llvm_lifetime_start_p0.Invoke(4L, &i);
				for (i = 0; i < 0; i = checked(i + 1))
				{
					b4 = (sbyte)((b4 >>> 1) + llvm_udiv_fix_i8.Invoke((sbyte)(b >>> 1), b4, 8));
				}
				llvm_lifetime_end_p0.Invoke(4L, &i);
				result = b4;
				llvm_lifetime_end_p0.Invoke(1L, &b4);
				llvm_lifetime_end_p0.Invoke(1L, &b3);
				llvm_lifetime_end_p0.Invoke(1L, &parameter_);
				llvm_lifetime_end_p0.Invoke(4L, &num);
				llvm_lifetime_end_p0.Invoke(1L, &b2);
			}
		}
		return result;
	}
}
