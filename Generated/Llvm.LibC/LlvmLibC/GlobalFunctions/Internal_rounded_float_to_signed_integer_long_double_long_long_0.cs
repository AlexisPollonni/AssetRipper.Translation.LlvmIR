using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_rounded_float_to_signed_integer_long_double_long_long_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal31rounded_float_to_signed_integerIexTnNS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE13is_integral_vIT0_EEiE4typeELi0EEES6_S5_")]
	[DemangledName("long long __llvm_libc_20_1_2_::fputil::internal::rounded_float_to_signed_integer<long double, long long, 0>(long double)")]
	[return: NativeType("long long")]
	public unsafe static long Invoke([MangledName("x")][NativeType("long double")] double X)
	{
		long num = 0L;
		long num2 = 0L;
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num3 = 0;
		int num4 = 0;
		Int128 x = default(Int128);
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = long.MinValue;
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = long.MaxValue;
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
		long result;
		unchecked
		{
			*(Int128*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi) = -6148914691236517206L;
			FPBits_long_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, X);
			Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
			*(sbyte*)(&anon_izyfb) = -86;
			if (FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_inf_or_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi))
			{
				Lambda_Invoke_iwr3zt.Invoke(&anon_izyfb);
				result = InstructionHelper.Select(FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_neg.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi), long.MinValue, long.MaxValue);
				goto IL_0209;
			}
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_exponent.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
			Llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = 63;
			if (num3 > 63)
			{
				Lambda_Invoke_iwr3zt.Invoke(&anon_izyfb);
				result = InstructionHelper.Select(FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_neg.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi), long.MinValue, long.MaxValue);
			}
			else
			{
				if (num3 != 63)
				{
					goto IL_01e1;
				}
				if (!FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_pos.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi))
				{
					Struct_fiz2nb struct_fiz2nb = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
					Int128* num5 = &x;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					*(long*)num5 = struct_fiz2nb2.field_0;
					byte* num6 = (byte*)(&x) + 8u;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					*(long*)num6 = struct_fiz2nb3.field_1;
					if (!NumericHelper.IntCmpNe(x, 0L))
					{
						goto IL_01e1;
					}
				}
				Lambda_Invoke_iwr3zt.Invoke(&anon_izyfb);
				result = InstructionHelper.Select(FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_neg.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi), long.MinValue, long.MaxValue);
			}
			goto IL_01e7;
		}
		IL_01e1:
		result = unchecked((long)X);
		goto IL_01e7;
		IL_0209:
		Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
		Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
		Llvm_lifetime_end_p0.Invoke(8L, &num2);
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
		IL_01e7:
		Llvm_lifetime_end_p0.Invoke(4L, &num4);
		Llvm_lifetime_end_p0.Invoke(4L, &num3);
		goto IL_0209;
	}
}
