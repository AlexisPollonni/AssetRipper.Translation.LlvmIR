using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fixed_point_sqrt_core_fixed_point_internal_SqrtConfig_unsigned_short_Fract
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point9sqrt_coreINS0_8internal10SqrtConfigIDRtEEEENT_4TypeES6_")]
	[DemangledName("__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned short _Fract>::Type __llvm_libc_20_1_2_::fixed_point::sqrt_core<__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned short _Fract>>(__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned short _Fract>::Type)")]
	[return: NativeType("__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned short _Fract>::Type")]
	public unsafe static sbyte Invoke([MangledName("x_frac")][NativeType("__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned short _Fract>::Type")] sbyte X_frac)
	{
		sbyte b = 0;
		sbyte b2 = 0;
		int num = 0;
		sbyte a = 0;
		sbyte b3 = 0;
		sbyte b4 = 0;
		int i = 0;
		b = X_frac;
		sbyte result;
		if (b == FXRep_unsigned_short_Fract_ONE_FOURTH.Invoke())
		{
			result = FXRep_unsigned_short_Fract_ONE_HALF.Invoke();
		}
		else
		{
			Llvm_lifetime_start_p0.Invoke(1L, &b2);
			b2 = Cpp_bit_cast_unsigned_char_unsigned_short_Fract.Invoke(&b);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = (unchecked((byte)b2) >> 4) - 4;
			Llvm_lifetime_start_p0.Invoke(1L, &a);
			long num2 = num;
			unchecked
			{
				a = ((sbyte*)Fixed_point_internal_SqrtConfig_unsigned_short_Fract_FIRST_APPROX.Pointer)[(nint)num2 * sizeof(InlineArray2_SByte)];
				Llvm_lifetime_start_p0.Invoke(1L, &b3);
				long num3 = num;
				b3 = (sbyte)((byte*)Fixed_point_internal_SqrtConfig_unsigned_short_Fract_FIRST_APPROX.Pointer + (nint)num3 * sizeof(InlineArray2_SByte))[1];
				Llvm_lifetime_start_p0.Invoke(1L, &b4);
				b4 = (sbyte)(Llvm_umul_fix_i8.Invoke(a, b, 8) + b3);
				Llvm_lifetime_start_p0.Invoke(4L, &i);
				for (i = 0; i < 0; i = checked(i + 1))
				{
					b4 = (sbyte)((b4 >>> 1) + Llvm_udiv_fix_i8.Invoke((sbyte)(b >>> 1), b4, 8));
				}
				Llvm_lifetime_end_p0.Invoke(4L, &i);
				result = b4;
				Llvm_lifetime_end_p0.Invoke(1L, &b4);
				Llvm_lifetime_end_p0.Invoke(1L, &b3);
				Llvm_lifetime_end_p0.Invoke(1L, &a);
				Llvm_lifetime_end_p0.Invoke(4L, &num);
				Llvm_lifetime_end_p0.Invoke(1L, &b2);
			}
		}
		return result;
	}
}
