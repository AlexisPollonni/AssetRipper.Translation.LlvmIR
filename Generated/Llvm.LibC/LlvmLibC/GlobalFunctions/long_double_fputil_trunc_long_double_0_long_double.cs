using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5truncIeTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_")]
[DemangledName("long double __llvm_libc_20_1_2_::fputil::trunc<long double, 0>(long double)")]
internal static partial class long_double_fputil_trunc_long_double_0_long_double
{
	public unsafe static double Invoke(double x)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		int num = 0;
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num2 = 0;
		Int128 @int = default(Int128);
		Int128 x2 = default(Int128);
		Int128 int2 = default(Int128);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			fputil_FPBits_long_double_FPBits_long_double_long_double.Invoke(&fputil_FPBits_ubgsi3, x);
			double result;
			if (fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_inf_or_nan_const.Invoke(&fputil_FPBits_ubgsi3))
			{
				result = x;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_exponent_const.Invoke(&fputil_FPBits_ubgsi3);
				if (num >= 63)
				{
					result = x;
				}
				else if (num <= -1)
				{
					llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
					anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_4_sign_const.Invoke(&fputil_FPBits_ubgsi3);
					Struct_fiz2nb struct_fiz2nb = fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_zero_Sign.Invoke(anon_izyfb8.val);
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
					llvm_lifetime_start_p0.Invoke(4L, &num2);
					num2 = checked(63 - num);
					llvm_lifetime_start_p0.Invoke(16L, &@int);
					Struct_fiz2nb struct_fiz2nb4 = fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa_const.Invoke(&fputil_FPBits_ubgsi3);
					Int128* num3 = &x2;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					*(long*)num3 = struct_fiz2nb5.field_0;
					byte* num4 = (byte*)(&x2) + 8u;
					Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
					*(long*)num4 = struct_fiz2nb6.field_1;
					@int = NumericHelper.ShiftLeft(NumericHelper.ShiftRightLogical(x2, (Int128)(UInt128)(uint)num2), (Int128)(UInt128)(uint)num2);
					int2 = @int;
					fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_mantissa_unsigned_int128.Invoke(&fputil_FPBits_ubgsi3, *(long*)(&int2), ((long*)(&int2))[1]);
					result = fputil_FPBits_long_double_get_val_const.Invoke(&fputil_FPBits_ubgsi3);
					llvm_lifetime_end_p0.Invoke(16L, &@int);
					llvm_lifetime_end_p0.Invoke(4L, &num2);
				}
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			return result;
		}
	}
}
