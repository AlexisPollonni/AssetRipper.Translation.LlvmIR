using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_intlogb_int_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7intlogbIieEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EET_E4typeES4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<long double>, int>::type __llvm_libc_20_1_2_::fputil::intlogb<int, long double>(long double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<long double>, int>::type")]
	public unsafe static int Invoke([MangledName("x")][NativeType("long double")] double X)
	{
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi = default(Fputil_FPBits_ubgsi2);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd = default(Fputil_DyadicFloat_kt2kd4);
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi) = -6148914691236517206L;
			FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi, X);
			int result;
			if (Details_expects_bool_condition_bool.Invoke(FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero.Invoke(&fputil_FPBits_ubgsi) || FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_inf_or_nan.Invoke(&fputil_FPBits_ubgsi), Expected: false))
			{
				Fputil_set_errno_if_required.Invoke(33);
				Fputil_raise_except_if_required.Invoke(1);
				result = ((!FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero.Invoke(&fputil_FPBits_ubgsi)) ? ((!FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan.Invoke(&fputil_FPBits_ubgsi)) ? int.MaxValue : int.MinValue) : int.MinValue);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd);
				*(sbyte*)(&fputil_DyadicFloat_kt2kd) = -86;
				sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_kt2kd) + 1;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				((int*)(&fputil_DyadicFloat_kt2kd))[1] = -1431655766;
				sbyte* ptr2 = (sbyte*)(&fputil_DyadicFloat_kt2kd) + 8;
				*(long*)ptr2 = -6148914691236517206L;
				((long*)ptr2)[1] = -6148914691236517206L;
				DyadicFloat_128ul_DyadicFloat_long_double_0.Invoke(&fputil_DyadicFloat_kt2kd, FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi));
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = DyadicFloat_128ul_get_unbiased_exponent.Invoke(&fputil_DyadicFloat_kt2kd);
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
				Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd);
			}
			Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi);
			return result;
		}
	}
}
