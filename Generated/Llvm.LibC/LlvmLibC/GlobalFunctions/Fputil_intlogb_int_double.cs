using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_intlogb_int_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7intlogbIidEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EET_E4typeES4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double>, int>::type __llvm_libc_20_1_2_::fputil::intlogb<int, double>(double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double>, int>::type")]
	public unsafe static int Invoke([MangledName("x")][NativeType("double")] double X)
	{
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		Fputil_DyadicFloat_syracv fputil_DyadicFloat_syracv = default(Fputil_DyadicFloat_syracv);
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm, X);
			int result;
			if (Details_expects_bool_condition_bool.Invoke(FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)) || FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)), Expected: false))
			{
				Fputil_set_errno_if_required.Invoke(33);
				Fputil_raise_except_if_required.Invoke(1);
				result = ((!FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm))) ? ((!FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm))) ? int.MaxValue : int.MinValue) : int.MinValue);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(16L, &fputil_DyadicFloat_syracv);
				*(sbyte*)(&fputil_DyadicFloat_syracv) = -86;
				sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_syracv) + 1;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				((int*)(&fputil_DyadicFloat_syracv))[1] = -1431655766;
				((long*)(&fputil_DyadicFloat_syracv))[1] = -6148914691236517206L;
				DyadicFloat_64ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_syracv, FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm));
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = DyadicFloat_64ul_get_unbiased_exponent.Invoke(&fputil_DyadicFloat_syracv);
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
				Llvm_lifetime_end_p0.Invoke(16L, &fputil_DyadicFloat_syracv);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
			return result;
		}
	}
}
