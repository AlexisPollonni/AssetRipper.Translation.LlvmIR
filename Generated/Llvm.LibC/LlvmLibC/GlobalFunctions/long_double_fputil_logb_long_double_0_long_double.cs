using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4logbIeTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_")]
[DemangledName("long double __llvm_libc_20_1_2_::fputil::logb<long double, 0>(long double)")]
internal static partial class long_double_fputil_logb_long_double_0_long_double
{
	public unsafe static double Invoke(double x)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi5 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd5 = default(fputil_DyadicFloat_kt2kd4);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			fputil_FPBits_long_double_FPBits_long_double_long_double.Invoke(&fputil_FPBits_ubgsi3, x);
			double result;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((!fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero_const.Invoke(&fputil_FPBits_ubgsi3)) ? fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_inf_or_nan_const.Invoke(&fputil_FPBits_ubgsi3) : true, expected: false))
			{
				if (fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan_const.Invoke(&fputil_FPBits_ubgsi3))
				{
					result = x;
				}
				else
				{
					fputil_raise_except_if_required_int.Invoke(4);
					if (fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero_const.Invoke(&fputil_FPBits_ubgsi3))
					{
						fputil_set_errno_if_required_int.Invoke(34);
						llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_NEG.Pointer, 1L, isVolatile: false);
						Struct_fiz2nb struct_fiz2nb = fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_inf_Sign.Invoke(anon_izyfb8.val);
						Int128* ptr = &fputil_FPBits_ubgsi4.val.Data.FPStorage.field_0;
						Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
						((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
						Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
						((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
						result = fputil_FPBits_long_double_get_val_const.Invoke(&fputil_FPBits_ubgsi4);
						llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
						Struct_fiz2nb struct_fiz2nb4 = fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_inf_Sign.Invoke(anon_izyfb9.val);
						Int128* ptr2 = &fputil_FPBits_ubgsi5.val.Data.FPStorage.field_0;
						Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
						((Struct_fiz2nb*)ptr2)->field_0 = struct_fiz2nb5.field_0;
						Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
						((Struct_fiz2nb*)ptr2)->field_1 = struct_fiz2nb6.field_1;
						result = fputil_FPBits_long_double_get_val_const.Invoke(&fputil_FPBits_ubgsi5);
						llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
					}
				}
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
				*(sbyte*)(&fputil_DyadicFloat_kt2kd5) = -86;
				sbyte* ptr3 = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 1;
				*ptr3 = -86;
				ptr3[1] = -86;
				ptr3[2] = -86;
				((int*)(&fputil_DyadicFloat_kt2kd5))[1] = -1431655766;
				sbyte* ptr4 = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 8;
				*(long*)ptr4 = -6148914691236517206L;
				((long*)ptr4)[1] = -6148914691236517206L;
				fputil_DyadicFloat_128ul_DyadicFloat_long_double_0_long_double.Invoke(&fputil_DyadicFloat_kt2kd5, fputil_FPBits_long_double_get_val_const.Invoke(&fputil_FPBits_ubgsi3));
				result = fputil_DyadicFloat_128ul_get_unbiased_exponent_const.Invoke(&fputil_DyadicFloat_kt2kd5);
				llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
			}
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			return result;
		}
	}
}
