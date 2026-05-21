using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_setpayload_false_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10setpayloadILb0EdEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EEbE4typeERS4_S4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double>, bool>::type __llvm_libc_20_1_2_::fputil::setpayload<false, double>(double&, double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double>, bool>::type")]
	public unsafe static bool Invoke([MangledName("res")][NativeType("double&")] void* Res, [MangledName("pl")][NativeType("double")] double Pl)
	{
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm2 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num = 0;
		long num2 = 0L;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm3 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		unchecked
		{
			*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, Pl);
			bool result;
			if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm)))
			{
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(anon_izyfb.Val, 0L);
				llvm_libc_20_1_2_fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.Val = val;
				*(double*)Res = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
				result = false;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
				if (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_neg.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm)) || num < 0 || num >= 51 || ((FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm)) << (int)(uint)num) & 0xFFFFFFFFFFFFFL) != 0L)
				{
					*(double*)Res = 0.0;
					result = true;
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(8L, &num2);
					num2 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm)) >>> (int)(uint)checked(52 - num);
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					long val2 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(V: num2, Sign: anon_izyfb2.Val);
					llvm_libc_20_1_2_fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.Val = val2;
					*(double*)Res = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
					result = false;
					Llvm_lifetime_end_p0.Invoke(8L, &num2);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
			return result;
		}
	}
}
