using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_intlogb_int_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7intlogbIifEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EET_E4typeES4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float>, int>::type __llvm_libc_20_1_2_::fputil::intlogb<int, float>(float)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float>, int>::type")]
	public unsafe static int Invoke([MangledName("x")][NativeType("float")] float X)
	{
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs = default(Fputil_FPBits_5nkvcs);
		Fputil_DyadicFloat_cs3nhs fputil_DyadicFloat_cs3nhs = default(Fputil_DyadicFloat_cs3nhs);
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs, X);
			int result;
			if (Details_expects_bool_condition_bool.Invoke(FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero.Invoke(&fputil_FPBits_5nkvcs) || FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs)), Expected: false))
			{
				Fputil_set_errno_if_required.Invoke(33);
				Fputil_raise_except_if_required.Invoke(1);
				result = ((!FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero.Invoke(&fputil_FPBits_5nkvcs)) ? ((!FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&fputil_FPBits_5nkvcs)) ? int.MaxValue : int.MinValue) : int.MinValue);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(12L, &fputil_DyadicFloat_cs3nhs);
				*(sbyte*)(&fputil_DyadicFloat_cs3nhs) = -86;
				sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_cs3nhs) + 1;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				((int*)(&fputil_DyadicFloat_cs3nhs))[1] = -1431655766;
				((int*)(&fputil_DyadicFloat_cs3nhs))[2] = -1431655766;
				DyadicFloat_32ul_DyadicFloat_float_0.Invoke(&fputil_DyadicFloat_cs3nhs, FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs));
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = DyadicFloat_32ul_get_unbiased_exponent.Invoke(&fputil_DyadicFloat_cs3nhs);
				if (Details_expects_bool_condition_bool.Invoke(num > int.MaxValue || num < int.MinValue, Expected: false))
				{
					Fputil_set_errno_if_required.Invoke(34);
					Fputil_raise_except_if_required.Invoke(1);
					result = InstructionHelper.Select(num > 0, int.MaxValue, int.MinValue);
				}
				else
				{
					result = num;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num);
				Llvm_lifetime_end_p0.Invoke(12L, &fputil_DyadicFloat_cs3nhs);
			}
			Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
			return result;
		}
	}
}
