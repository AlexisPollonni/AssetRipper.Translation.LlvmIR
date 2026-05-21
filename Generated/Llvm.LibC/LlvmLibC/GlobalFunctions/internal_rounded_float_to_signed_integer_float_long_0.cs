using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_rounded_float_to_signed_integer_float_long_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal31rounded_float_to_signed_integerIflTnNS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE13is_integral_vIT0_EEiE4typeELi0EEES6_S5_")]
	[DemangledName("long __llvm_libc_20_1_2_::fputil::internal::rounded_float_to_signed_integer<float, long, 0>(float)")]
	[return: NativeType("long")]
	public unsafe static long Invoke([NativeType("float")] float x)
	{
		long num = 0L;
		long num2 = 0L;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num3 = 0;
		int num4 = 0;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = long.MinValue;
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = long.MaxValue;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
			*(sbyte*)(&anon_izyfb8) = -86;
			long result;
			if (FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)))
			{
				lambda_Invoke_9ahikq.Invoke(&anon_izyfb8);
				result = InstructionHelper.Select(FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_neg.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)), long.MinValue, long.MaxValue);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_exponent.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
				llvm_lifetime_start_p0.Invoke(4L, &num4);
				num4 = 63;
				if (num3 > 63)
				{
					lambda_Invoke_9ahikq.Invoke(&anon_izyfb8);
					result = InstructionHelper.Select(FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_neg.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)), long.MinValue, long.MaxValue);
				}
				else if (num3 == 63 && (FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_pos.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) || FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) != 0))
				{
					lambda_Invoke_9ahikq.Invoke(&anon_izyfb8);
					result = InstructionHelper.Select(FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_neg.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)), long.MinValue, long.MaxValue);
				}
				else
				{
					result = (long)x;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num4);
				llvm_lifetime_end_p0.Invoke(4L, &num3);
			}
			llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
