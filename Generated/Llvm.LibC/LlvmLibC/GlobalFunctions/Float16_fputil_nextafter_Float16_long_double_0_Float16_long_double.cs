using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil9nextafterIDF16_eTnNS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS4_stS5_EiE4typeELi0EEES4_S4_S5_")]
[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::nextafter<_Float16, long double, 0>(_Float16, long double)")]
internal static partial class Float16_fputil_nextafter_Float16_long_double_0_Float16_long_double
{
	public unsafe static Half Invoke(Half from, double to)
	{
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(fputil_FPBits_2fahva);
		fputil_FPBits_2fahva fputil_FPBits_2fahva5 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva2) = -21846;
			fputil_FPBits_Float16_FPBits_Float16_Float16.Invoke(&fputil_FPBits_2fahva2, from);
			Half result;
			if (fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_nan_const.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2)))
			{
				result = from;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
				*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
				fputil_FPBits_long_double_FPBits_long_double_long_double.Invoke(&fputil_FPBits_ubgsi3, to);
				if (fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan_const.Invoke(&fputil_FPBits_ubgsi3))
				{
					result = cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_long_double_Float16_type_fputil_cast_Float16_long_double_long_double.Invoke(to);
				}
				else if (cpp_enable_if_cpp_is_floating_point_v_long_double_cpp_is_floating_point_v_Float16_long_double_type_fputil_cast_long_double_Float16_Float16.Invoke(from) == to)
				{
					result = cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_long_double_Float16_type_fputil_cast_Float16_long_double_long_double.Invoke(to);
				}
				else
				{
					if (NumericHelper.IsUnorderedOrNotEquals(from, default(Half)))
					{
						if (cpp_enable_if_cpp_is_floating_point_v_long_double_cpp_is_floating_point_v_Float16_long_double_type_fputil_cast_long_double_Float16_Float16.Invoke(from) < to == NumericHelper.FcmpOgt(from, default(Half)))
						{
							llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
							fputil_FPBits_Float16_FPBits_unsigned_short_unsigned_short.Invoke(&fputil_FPBits_2fahva3, (short)checked(unchecked((ushort)fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval_const.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2))) + 1));
							llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_2fahva2, &fputil_FPBits_2fahva3, 2L, isVolatile: false);
							llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
						}
						else
						{
							llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
							fputil_FPBits_Float16_FPBits_unsigned_short_unsigned_short.Invoke(&fputil_FPBits_2fahva4, (short)checked(unchecked((ushort)fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval_const.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2))) - 1));
							llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_2fahva2, &fputil_FPBits_2fahva4, 2L, isVolatile: false);
							llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
						}
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva5);
						anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_4_sign_const.Invoke(&fputil_FPBits_ubgsi3);
						short field_ = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_min_subnormal_Sign.Invoke(anon_izyfb8.val);
						fputil_FPBits_2fahva5.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_2fahva2, &fputil_FPBits_2fahva5, 2L, isVolatile: false);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva5);
					}
					if (fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_subnormal_const.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2)))
					{
						fputil_raise_except_if_required_int.Invoke(48);
					}
					else if (fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_inf_const.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2)))
					{
						fputil_raise_except_if_required_int.Invoke(40);
					}
					result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva2);
				}
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			}
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			return result;
		}
	}
}
