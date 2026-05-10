using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4ceilIgTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_")]
[DemangledName("__float128 __llvm_libc_20_1_2_::fputil::ceil<__float128, 0>(__float128)")]
internal static partial class float128_fputil_ceil_float128_0_float128
{
	public unsafe static double Invoke(double x)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		sbyte b = 0;
		int num = 0;
		int num2 = 0;
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		Int128 int3 = default(Int128);
		Int128 int4 = default(Int128);
		double num3 = 0.0;
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			fputil_FPBits_float128_FPBits_float128_float128.Invoke(&fputil_FPBits_ubgsi3, x);
			double result;
			if (fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_is_inf_or_nan_const.Invoke(&fputil_FPBits_ubgsi3) || fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero_const.Invoke(&fputil_FPBits_ubgsi3))
			{
				result = x;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(1L, &b);
				b = (fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_is_neg_const.Invoke(&fputil_FPBits_ubgsi3) ? ((sbyte)1) : ((sbyte)0));
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_exponent_const.Invoke(&fputil_FPBits_ubgsi3);
				if (num >= 112)
				{
					result = x;
				}
				else if (num <= -1)
				{
					result = (((b & 1) != 1) ? 1.0 : 0.0);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(4L, &num2);
					num2 = checked(112 - num);
					llvm_lifetime_start_p0.Invoke(16L, &@int);
					Struct_fiz2nb struct_fiz2nb = fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_uintval_const.Invoke(&fputil_FPBits_ubgsi3);
					Int128* num4 = &int2;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					*(long*)num4 = struct_fiz2nb2.field_0;
					byte* num5 = (byte*)(&int2) + 8u;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					*(long*)num5 = struct_fiz2nb3.field_1;
					@int = int2;
					llvm_lifetime_start_p0.Invoke(16L, &int3);
					int3 = NumericHelper.ShiftLeft(NumericHelper.ShiftRightLogical(@int, (Int128)(UInt128)(uint)num2), (Int128)(UInt128)(uint)num2);
					if (NumericHelper.IntCmpEq(int3, @int))
					{
						result = x;
					}
					else
					{
						int4 = int3;
						fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_set_uintval_unsigned_int128.Invoke(&fputil_FPBits_ubgsi3, *(long*)(&int4), ((long*)(&int4))[1]);
						llvm_lifetime_start_p0.Invoke(16L, &num3);
						num3 = fputil_FPBits_float128_get_val_const.Invoke(&fputil_FPBits_ubgsi3);
						result = (((b & 1) != 1) ? (num3 + 1.0) : num3);
						llvm_lifetime_end_p0.Invoke(16L, &num3);
					}
					llvm_lifetime_end_p0.Invoke(16L, &int3);
					llvm_lifetime_end_p0.Invoke(16L, &@int);
					llvm_lifetime_end_p0.Invoke(4L, &num2);
				}
				llvm_lifetime_end_p0.Invoke(4L, &num);
				llvm_lifetime_end_p0.Invoke(1L, &b);
			}
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			return result;
		}
	}
}
