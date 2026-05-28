using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_round_float128_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5roundIgTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_")]
	[DemangledName("__float128 __llvm_libc_20_1_2_::fputil::round<__float128, 0>(__float128)")]
	[return: NativeType("__float128")]
	public unsafe static double Invoke([MangledName("x")][NativeType("__float128")] double X)
	{
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi = default(Fputil_FPBits_ubgsi2);
		int num = 0;
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi2 = default(Fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(Fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		int num2 = 0;
		sbyte b = 0;
		Int128 x = default(Int128);
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		Int128 int3 = default(Int128);
		Int128 int4 = default(Int128);
		double num3 = 0.0;
		Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi) = -6148914691236517206L;
			FPBits_float128_Constructor.Invoke(&fputil_FPBits_ubgsi, X);
			double result;
			if (FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_is_inf_or_nan.Invoke(&fputil_FPBits_ubgsi) || FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi)))
			{
				result = X;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_exponent.Invoke(&fputil_FPBits_ubgsi);
				if (num >= 112)
				{
					result = X;
				}
				else if (num == -1)
				{
					Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi2);
					anon_izyfb.Val = FPStorage_fputil_FPType_3_sign.Invoke(&fputil_FPBits_ubgsi);
					Struct_fiz2nb struct_fiz2nb = FPRepSem_fputil_FPType_3_fputil_FPBits_float128_one.Invoke(anon_izyfb.Val);
					Int128* ptr = &fputil_FPBits_ubgsi2.Val.Data.FPStorage.field_0;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
					result = FPBits_float128_get_val.Invoke(&fputil_FPBits_ubgsi2);
					Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi2);
				}
				else if (num <= -2)
				{
					Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
					anon_izyfb2.Val = FPStorage_fputil_FPType_3_sign.Invoke(&fputil_FPBits_ubgsi);
					Struct_fiz2nb struct_fiz2nb4 = FPRepSem_fputil_FPType_3_fputil_FPBits_float128_zero.Invoke(anon_izyfb2.Val);
					Int128* ptr2 = &fputil_FPBits_ubgsi3.Val.Data.FPStorage.field_0;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					((Struct_fiz2nb*)ptr2)->field_0 = struct_fiz2nb5.field_0;
					Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
					((Struct_fiz2nb*)ptr2)->field_1 = struct_fiz2nb6.field_1;
					result = FPBits_float128_get_val.Invoke(&fputil_FPBits_ubgsi3);
					Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num2);
					num2 = checked(112 - num);
					Llvm_lifetime_start_p0.Invoke(1L, &b);
					Struct_fiz2nb struct_fiz2nb7 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa.Invoke(&fputil_FPBits_ubgsi);
					Int128* num4 = &x;
					Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
					*(long*)num4 = struct_fiz2nb8.field_0;
					byte* num5 = (byte*)(&x) + 8u;
					Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
					*(long*)num5 = struct_fiz2nb9.field_1;
					b = (NumericHelper.IntCmpNe(NumericHelper.BitwiseAnd(x, NumericHelper.ShiftLeft(y: (Int128)(UInt128)(uint)(num2 - 1), x: 1L)), 0L) ? ((sbyte)1) : ((sbyte)0));
					Llvm_lifetime_start_p0.Invoke(16L, &@int);
					Struct_fiz2nb struct_fiz2nb10 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_uintval.Invoke(&fputil_FPBits_ubgsi);
					Int128* num6 = &int2;
					Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
					*(long*)num6 = struct_fiz2nb11.field_0;
					byte* num7 = (byte*)(&int2) + 8u;
					Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
					*(long*)num7 = struct_fiz2nb12.field_1;
					@int = int2;
					Llvm_lifetime_start_p0.Invoke(16L, &int3);
					int3 = NumericHelper.ShiftLeft(NumericHelper.ShiftRightLogical(@int, (Int128)(UInt128)(uint)num2), (Int128)(UInt128)(uint)num2);
					if (NumericHelper.IntCmpEq(int3, @int))
					{
						result = X;
					}
					else
					{
						int4 = int3;
						FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_set_uintval.Invoke(&fputil_FPBits_ubgsi, *(long*)(&int4), ((long*)(&int4))[1]);
						Llvm_lifetime_start_p0.Invoke(16L, &num3);
						num3 = FPBits_float128_get_val.Invoke(&fputil_FPBits_ubgsi);
						result = (((b & 1) == 1) ? ((!FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_is_neg.Invoke(&fputil_FPBits_ubgsi)) ? (num3 + 1.0) : (num3 - 1.0)) : num3);
						Llvm_lifetime_end_p0.Invoke(16L, &num3);
					}
					Llvm_lifetime_end_p0.Invoke(16L, &int3);
					Llvm_lifetime_end_p0.Invoke(16L, &@int);
					Llvm_lifetime_end_p0.Invoke(1L, &b);
					Llvm_lifetime_end_p0.Invoke(4L, &num2);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi);
			return result;
		}
	}
}
