using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4modfIgTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_RS4_")]
[DemangledName("__float128 __llvm_libc_20_1_2_::fputil::modf<__float128, 0>(__float128, __float128&)")]
internal static partial class float128_fputil_modf_float128_0_float128_float128
{
	public unsafe static double Invoke(double x, void* iptr)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi5 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			fputil_FPBits_float128_FPBits_float128_float128.Invoke(&fputil_FPBits_ubgsi3, x);
			double result;
			if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero_const.Invoke(&fputil_FPBits_ubgsi3) || fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan_const.Invoke(&fputil_FPBits_ubgsi3))
			{
				*(double*)iptr = x;
				result = x;
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_inf_const.Invoke(&fputil_FPBits_ubgsi3))
			{
				*(double*)iptr = x;
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
				anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_3_sign_const.Invoke(&fputil_FPBits_ubgsi3);
				Struct_fiz2nb struct_fiz2nb = fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_zero_Sign.Invoke(anon_izyfb8.val);
				Int128* ptr = &fputil_FPBits_ubgsi4.val.Data.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
				result = fputil_FPBits_float128_get_val_const.Invoke(&fputil_FPBits_ubgsi4);
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			}
			else
			{
				*(double*)iptr = float128_fputil_trunc_float128_0_float128.Invoke(x);
				if (x == *(double*)iptr)
				{
					llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
					anon_izyfb9.val = fputil_internal_FPStorage_fputil_FPType_3_sign_const.Invoke(&fputil_FPBits_ubgsi3);
					Struct_fiz2nb struct_fiz2nb4 = fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_zero_Sign.Invoke(anon_izyfb9.val);
					Int128* ptr2 = &fputil_FPBits_ubgsi5.val.Data.FPStorage.field_0;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					((Struct_fiz2nb*)ptr2)->field_0 = struct_fiz2nb5.field_0;
					Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
					((Struct_fiz2nb*)ptr2)->field_1 = struct_fiz2nb6.field_1;
					result = fputil_FPBits_float128_get_val_const.Invoke(&fputil_FPBits_ubgsi5);
					llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
				}
				else
				{
					result = x - *(double*)iptr;
				}
			}
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			return result;
		}
	}
}
