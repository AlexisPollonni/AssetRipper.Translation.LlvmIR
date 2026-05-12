using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil9nextafterIggTnNS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS4_stS5_EiE4typeELi0EEES4_S4_S5_")]
[DemangledName("__float128 __llvm_libc_20_1_2_::fputil::nextafter<__float128, __float128, 0>(__float128, __float128)")]
internal static partial class float128_fputil_nextafter_float128_float128_0_float128_float128
{
	public unsafe static double Invoke(double from, double to)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi5 = default(fputil_FPBits_ubgsi2);
		Int128 x = default(Int128);
		Int128 @int = default(Int128);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi6 = default(fputil_FPBits_ubgsi2);
		Int128 x2 = default(Int128);
		Int128 int2 = default(Int128);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi7 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			fputil_FPBits_float128_FPBits_float128_float128.Invoke(&fputil_FPBits_ubgsi3, from);
			double result;
			if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi3)))
			{
				result = from;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
				*(Int128*)(&fputil_FPBits_ubgsi4) = -6148914691236517206L;
				fputil_FPBits_float128_FPBits_float128_float128.Invoke(&fputil_FPBits_ubgsi4, to);
				if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi4)))
				{
					result = cpp_enable_if_cpp_is_floating_point_v_float128_cpp_is_floating_point_v_float128_float128_type_fputil_cast_float128_float128_float128.Invoke(to);
				}
				else if (cpp_enable_if_cpp_is_floating_point_v_float128_cpp_is_floating_point_v_float128_float128_type_fputil_cast_float128_float128_float128.Invoke(from) == to)
				{
					result = cpp_enable_if_cpp_is_floating_point_v_float128_cpp_is_floating_point_v_float128_float128_type_fputil_cast_float128_float128_float128.Invoke(to);
				}
				else
				{
					if (NumericHelper.IsUnorderedOrNotEquals(from, 0.0))
					{
						if (cpp_enable_if_cpp_is_floating_point_v_float128_cpp_is_floating_point_v_float128_float128_type_fputil_cast_float128_float128_float128.Invoke(from) < to == from > 0.0)
						{
							llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
							Struct_fiz2nb struct_fiz2nb = fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_uintval_const.Invoke(&fputil_FPBits_ubgsi3);
							Int128* num = &x;
							Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
							*(long*)num = struct_fiz2nb2.field_0;
							byte* num2 = (byte*)(&x) + 8u;
							Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
							*(long*)num2 = struct_fiz2nb3.field_1;
							@int = NumericHelper.Add(x, 1L);
							fputil_FPBits_float128_FPBits_unsigned_int128_unsigned_int128.Invoke(&fputil_FPBits_ubgsi5, *(long*)(&@int), ((long*)(&@int))[1]);
							llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi3, &fputil_FPBits_ubgsi5, 16L, isVolatile: false);
							llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
						}
						else
						{
							llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi6);
							Struct_fiz2nb struct_fiz2nb4 = fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_uintval_const.Invoke(&fputil_FPBits_ubgsi3);
							Int128* num3 = &x2;
							Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
							*(long*)num3 = struct_fiz2nb5.field_0;
							byte* num4 = (byte*)(&x2) + 8u;
							Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
							*(long*)num4 = struct_fiz2nb6.field_1;
							int2 = NumericHelper.Subtract(x2, 1L);
							fputil_FPBits_float128_FPBits_unsigned_int128_unsigned_int128.Invoke(&fputil_FPBits_ubgsi6, *(long*)(&int2), ((long*)(&int2))[1]);
							llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi3, &fputil_FPBits_ubgsi6, 16L, isVolatile: false);
							llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi6);
						}
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi7);
						anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_3_sign_const.Invoke(&fputil_FPBits_ubgsi4);
						Struct_fiz2nb struct_fiz2nb7 = fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_min_subnormal_Sign.Invoke(anon_izyfb8.val);
						Int128* ptr = &fputil_FPBits_ubgsi7.val.Data.FPStorage.field_0;
						Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
						((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb8.field_0;
						Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
						((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb9.field_1;
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi3, &fputil_FPBits_ubgsi7, 16L, isVolatile: false);
						llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi7);
					}
					if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_subnormal_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi3)))
					{
						fputil_raise_except_if_required_int.Invoke(48);
					}
					else if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_inf_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi3)))
					{
						fputil_raise_except_if_required_int.Invoke(40);
					}
					result = fputil_FPBits_float128_get_val_const.Invoke(&fputil_FPBits_ubgsi3);
				}
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			}
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			return result;
		}
	}
}
