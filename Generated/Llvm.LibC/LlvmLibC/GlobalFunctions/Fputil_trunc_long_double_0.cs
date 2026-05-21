using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_trunc_long_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5truncIeTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_")]
	[DemangledName("long double __llvm_libc_20_1_2_::fputil::trunc<long double, 0>(long double)")]
	[return: NativeType("long double")]
	public unsafe static double Invoke([MangledName("x")][NativeType("long double")] double X)
	{
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		int num = 0;
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi2 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num2 = 0;
		Int128 @int = default(Int128);
		Int128 x = default(Int128);
		Int128 int2 = default(Int128);
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
		unchecked
		{
			*(Int128*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi) = -6148914691236517206L;
			FPBits_long_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, X);
			double result;
			if (FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_inf_or_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi))
			{
				result = X;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_exponent.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
				if (num >= 63)
				{
					result = X;
				}
				else if (num <= -1)
				{
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
					anon_izyfb.Val = FPStorage_fputil_FPType_4_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
					Struct_fiz2nb struct_fiz2nb = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_zero.Invoke(anon_izyfb.Val);
					Int128* ptr = &llvm_libc_20_1_2_fputil_FPBits_ubgsi2.Val.Data.FPStorage.field_0;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
					result = FPBits_long_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num2);
					num2 = checked(63 - num);
					Llvm_lifetime_start_p0.Invoke(16L, &@int);
					Struct_fiz2nb struct_fiz2nb4 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
					Int128* num3 = &x;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					*(long*)num3 = struct_fiz2nb5.field_0;
					byte* num4 = (byte*)(&x) + 8u;
					Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
					*(long*)num4 = struct_fiz2nb6.field_1;
					@int = NumericHelper.ShiftLeft(NumericHelper.ShiftRightLogical(x, (Int128)(UInt128)(uint)num2), (Int128)(UInt128)(uint)num2);
					int2 = @int;
					FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, *(long*)(&int2), ((long*)(&int2))[1]);
					result = FPBits_long_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
					Llvm_lifetime_end_p0.Invoke(16L, &@int);
					Llvm_lifetime_end_p0.Invoke(4L, &num2);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
			return result;
		}
	}
}
