using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_intlogb_int_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7intlogbIifEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EET_E4typeES4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float>, int>::type __llvm_libc_20_1_2_::fputil::intlogb<int, float>(float)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float>, int>::type")]
	public unsafe static int Invoke([NativeType("float")] float x)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		fputil_DyadicFloat_cs3nhs fputil_DyadicFloat_cs3nhs2 = default(fputil_DyadicFloat_cs3nhs);
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs2, x);
			int result;
			if (details_expects_bool_condition_bool.Invoke((!FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero.Invoke(&fputil_FPBits_5nkvcs2)) ? FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) : true, expected: false))
			{
				fputil_set_errno_if_required.Invoke(33);
				fputil_raise_except_if_required.Invoke(1);
				result = ((!FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero.Invoke(&fputil_FPBits_5nkvcs2)) ? ((!FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&fputil_FPBits_5nkvcs2)) ? int.MaxValue : int.MinValue) : int.MinValue);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(12L, &fputil_DyadicFloat_cs3nhs2);
				*(sbyte*)(&fputil_DyadicFloat_cs3nhs2) = -86;
				sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_cs3nhs2) + 1;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				((int*)(&fputil_DyadicFloat_cs3nhs2))[1] = -1431655766;
				((int*)(&fputil_DyadicFloat_cs3nhs2))[2] = -1431655766;
				DyadicFloat_32ul_DyadicFloat_float_0.Invoke(&fputil_DyadicFloat_cs3nhs2, FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs2));
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = DyadicFloat_32ul_get_unbiased_exponent.Invoke(&fputil_DyadicFloat_cs3nhs2);
				if (details_expects_bool_condition_bool.Invoke((num <= int.MaxValue) ? (num < int.MinValue) : true, expected: false))
				{
					fputil_set_errno_if_required.Invoke(34);
					fputil_raise_except_if_required.Invoke(1);
					result = InstructionHelper.Select(num > 0, int.MaxValue, int.MinValue);
				}
				else
				{
					result = num;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num);
				llvm_lifetime_end_p0.Invoke(12L, &fputil_DyadicFloat_cs3nhs2);
			}
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			return result;
		}
	}
}
