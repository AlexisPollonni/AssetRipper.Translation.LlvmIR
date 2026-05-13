using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12fmaximum_numIgTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_S4_")]
[DemangledName("__float128 __llvm_libc_20_1_2_::fputil::fmaximum_num<__float128, 0>(__float128, __float128)")]
internal static partial class float128_fputil_fmaximum_num_float128_0_float128_float128
{
	public unsafe static double Invoke(double x, double y)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi5 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		Int128 @int = default(Int128);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		double result;
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			fputil_FPBits_float128_FPBits_float128_float128.Invoke(&fputil_FPBits_ubgsi3, x);
			llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			*(Int128*)(&fputil_FPBits_ubgsi4) = -6148914691236517206L;
			fputil_FPBits_float128_FPBits_float128_float128.Invoke(&fputil_FPBits_ubgsi4, y);
			if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_signaling_nan_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi3)) || fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_signaling_nan_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi4)))
			{
				fputil_raise_except_if_required_int.Invoke(1);
				if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi3)) && fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi4)))
				{
					llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
					sbyte val = anon_izyfb8.val;
					@int = 0L;
					Struct_fiz2nb struct_fiz2nb = fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_quiet_nan_Sign_unsigned_int128.Invoke(val, *(long*)(&@int), ((long*)(&@int))[1]);
					Int128* ptr = &fputil_FPBits_ubgsi5.val.Data.FPStorage.field_0;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
					result = fputil_FPBits_float128_get_val_const.Invoke(&fputil_FPBits_ubgsi5);
					llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
					goto IL_01ad;
				}
			}
			result = ((!fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi3))) ? ((!fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi4))) ? cpp_enable_if_cpp_is_floating_point_v_float128_float128_type_fputil_internal_max_float128_float128_float128.Invoke(x, y) : x) : y);
			goto IL_01ad;
		}
		IL_01ad:
		llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
		llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		return result;
	}
}
