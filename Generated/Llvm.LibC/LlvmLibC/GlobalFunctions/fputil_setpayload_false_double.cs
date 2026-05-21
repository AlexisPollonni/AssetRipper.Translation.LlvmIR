using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_setpayload_false_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10setpayloadILb0EdEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EEbE4typeERS4_S4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double>, bool>::type __llvm_libc_20_1_2_::fputil::setpayload<false, double>(double&, double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double>, bool>::type")]
	public unsafe static bool Invoke([NativeType("double&")] void* res, [NativeType("double")] double pl)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num = 0;
		long num2 = 0L;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2, pl);
			bool result;
			if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
			{
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
				long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(anon_izyfb8.val, 0L);
				fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.val = val;
				*(double*)res = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm3);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				result = false;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_exponent.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
				if (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_neg.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) || num < 0 || num >= 51 || ((FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) << (int)(uint)num) & 0xFFFFFFFFFFFFFL) != 0L)
				{
					*(double*)res = 0.0;
					result = true;
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(8L, &num2);
					num2 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)) >>> (int)(uint)checked(52 - num);
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
					long val2 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(v: num2, sign: anon_izyfb9.val);
					fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.val = val2;
					*(double*)res = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm4);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
					result = false;
					llvm_lifetime_end_p0.Invoke(8L, &num2);
				}
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			return result;
		}
	}
}
