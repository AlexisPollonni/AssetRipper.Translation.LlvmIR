using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_rounded_float_to_signed_integer_float_long_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal31rounded_float_to_signed_integerIflTnNS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE13is_integral_vIT0_EEiE4typeELi0EEES6_S5_")]
	[DemangledName("long __llvm_libc_20_1_2_::fputil::internal::rounded_float_to_signed_integer<float, long, 0>(float)")]
	[return: NativeType("long")]
	public unsafe static long Invoke([MangledName("x")][NativeType("float")] float X)
	{
		long num = 0L;
		long num2 = 0L;
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num3 = 0;
		int num4 = 0;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = long.MinValue;
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = long.MaxValue;
		Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs, X);
			Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
			*(sbyte*)(&anon_izyfb) = -86;
			long result;
			if (FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs)))
			{
				Lambda_Invoke_9ahikq.Invoke(&anon_izyfb);
				result = InstructionHelper.Select(FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_neg.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs)), long.MinValue, long.MaxValue);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_exponent.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs));
				Llvm_lifetime_start_p0.Invoke(4L, &num4);
				num4 = 63;
				if (num3 > 63)
				{
					Lambda_Invoke_9ahikq.Invoke(&anon_izyfb);
					result = InstructionHelper.Select(FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_neg.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs)), long.MinValue, long.MaxValue);
				}
				else if (num3 == 63 && (FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_pos.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs)) || FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs)) != 0))
				{
					Lambda_Invoke_9ahikq.Invoke(&anon_izyfb);
					result = InstructionHelper.Select(FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_neg.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs)), long.MinValue, long.MaxValue);
				}
				else
				{
					result = (long)X;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num4);
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
			}
			Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
			Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
