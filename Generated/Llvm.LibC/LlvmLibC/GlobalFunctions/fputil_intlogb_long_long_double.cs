using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_intlogb_long_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7intlogbIleEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EET_E4typeES4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<long double>, long>::type __llvm_libc_20_1_2_::fputil::intlogb<long, long double>(long double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<long double>, long>::type")]
	public unsafe static long Invoke([NativeType("long double")] double x)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd5 = default(fputil_DyadicFloat_kt2kd4);
		int num = 0;
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi3, x);
			long result;
			if (details_expects_bool_condition_bool.Invoke((!FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero.Invoke(&fputil_FPBits_ubgsi3)) ? FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_inf_or_nan.Invoke(&fputil_FPBits_ubgsi3) : true, expected: false))
			{
				fputil_set_errno_if_required.Invoke(33);
				fputil_raise_except_if_required.Invoke(1);
				result = ((!FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero.Invoke(&fputil_FPBits_ubgsi3)) ? ((!FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan.Invoke(&fputil_FPBits_ubgsi3)) ? long.MaxValue : (-2147483648L)) : (-2147483648L));
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
				*(sbyte*)(&fputil_DyadicFloat_kt2kd5) = -86;
				sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 1;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				((int*)(&fputil_DyadicFloat_kt2kd5))[1] = -1431655766;
				sbyte* ptr2 = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 8;
				*(long*)ptr2 = -6148914691236517206L;
				((long*)ptr2)[1] = -6148914691236517206L;
				DyadicFloat_128ul_DyadicFloat_long_double_0.Invoke(&fputil_DyadicFloat_kt2kd5, FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi3));
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = DyadicFloat_128ul_get_unbiased_exponent.Invoke(&fputil_DyadicFloat_kt2kd5);
				if (details_expects_bool_condition_bool.Invoke((num <= long.MaxValue) ? (num < long.MinValue) : true, expected: false))
				{
					fputil_set_errno_if_required.Invoke(34);
					fputil_raise_except_if_required.Invoke(1);
					result = InstructionHelper.Select(num > 0, long.MaxValue, long.MinValue);
				}
				else
				{
					result = num;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num);
				llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
			}
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			return result;
		}
	}
}
