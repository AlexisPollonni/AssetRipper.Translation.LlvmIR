using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_rounded_float_to_signed_integer_double_long_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal31rounded_float_to_signed_integerIdlTnNS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE13is_integral_vIT0_EEiE4typeELi0EEES6_S5_")]
	[DemangledName("long __llvm_libc_20_1_2_::fputil::internal::rounded_float_to_signed_integer<double, long, 0>(double)")]
	[return: NativeType("long")]
	public unsafe static long Invoke([MangledName("x")][NativeType("double")] double X)
	{
		long num = 0L;
		long num2 = 0L;
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num3 = 0;
		int num4 = 0;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = long.MinValue;
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = long.MaxValue;
		Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm, X);
			Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
			*(sbyte*)(&anon_izyfb) = -86;
			long result;
			if (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)))
			{
				Lambda_Invoke_ixec5p.Invoke(&anon_izyfb);
				result = InstructionHelper.Select(FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_neg.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)), long.MinValue, long.MaxValue);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_exponent.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm));
				Llvm_lifetime_start_p0.Invoke(4L, &num4);
				num4 = 63;
				if (num3 > 63)
				{
					Lambda_Invoke_ixec5p.Invoke(&anon_izyfb);
					result = InstructionHelper.Select(FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_neg.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)), long.MinValue, long.MaxValue);
				}
				else if (num3 == 63 && (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_pos.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)) || FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)) != 0L))
				{
					Lambda_Invoke_ixec5p.Invoke(&anon_izyfb);
					result = InstructionHelper.Select(FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_neg.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)), long.MinValue, long.MaxValue);
				}
				else
				{
					result = (long)X;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num4);
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
			}
			Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
