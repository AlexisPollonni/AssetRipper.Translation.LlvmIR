using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_round_float128_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5roundIgTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_")]
	[DemangledName("__float128 __llvm_libc_20_1_2_::fputil::round<__float128, 0>(__float128)")]
	[return: NativeType("__float128")]
	public unsafe static double Invoke([NativeType("__float128")] double x)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		int num = 0;
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi5 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		int num2 = 0;
		sbyte b = 0;
		Int128 x2 = default(Int128);
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		Int128 int3 = default(Int128);
		Int128 int4 = default(Int128);
		double num3 = 0.0;
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			FPBits_float128_Constructor.Invoke(&fputil_FPBits_ubgsi3, x);
			double result;
			if (FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_is_inf_or_nan.Invoke(&fputil_FPBits_ubgsi3) || FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi3)))
			{
				result = x;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_exponent.Invoke(&fputil_FPBits_ubgsi3);
				if (num >= 112)
				{
					result = x;
				}
				else if (num == -1)
				{
					llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
					anon_izyfb8.val = FPStorage_fputil_FPType_3_sign.Invoke(&fputil_FPBits_ubgsi3);
					Struct_fiz2nb struct_fiz2nb = FPRepSem_fputil_FPType_3_fputil_FPBits_float128_one.Invoke(anon_izyfb8.val);
					Int128* ptr = &fputil_FPBits_ubgsi4.val.Data.FPStorage.field_0;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
					result = FPBits_float128_get_val.Invoke(&fputil_FPBits_ubgsi4);
					llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
				}
				else if (num <= -2)
				{
					llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
					anon_izyfb9.val = FPStorage_fputil_FPType_3_sign.Invoke(&fputil_FPBits_ubgsi3);
					Struct_fiz2nb struct_fiz2nb4 = FPRepSem_fputil_FPType_3_fputil_FPBits_float128_zero.Invoke(anon_izyfb9.val);
					Int128* ptr2 = &fputil_FPBits_ubgsi5.val.Data.FPStorage.field_0;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					((Struct_fiz2nb*)ptr2)->field_0 = struct_fiz2nb5.field_0;
					Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
					((Struct_fiz2nb*)ptr2)->field_1 = struct_fiz2nb6.field_1;
					result = FPBits_float128_get_val.Invoke(&fputil_FPBits_ubgsi5);
					llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(4L, &num2);
					num2 = checked(112 - num);
					llvm_lifetime_start_p0.Invoke(1L, &b);
					Struct_fiz2nb struct_fiz2nb7 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa.Invoke(&fputil_FPBits_ubgsi3);
					Int128* num4 = &x2;
					Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
					*(long*)num4 = struct_fiz2nb8.field_0;
					byte* num5 = (byte*)(&x2) + 8u;
					Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
					*(long*)num5 = struct_fiz2nb9.field_1;
					b = (NumericHelper.IntCmpNe(NumericHelper.BitwiseAnd(x2, NumericHelper.ShiftLeft(y: (Int128)(UInt128)(uint)(num2 - 1), x: 1L)), 0L) ? ((sbyte)1) : ((sbyte)0));
					llvm_lifetime_start_p0.Invoke(16L, &@int);
					Struct_fiz2nb struct_fiz2nb10 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_uintval.Invoke(&fputil_FPBits_ubgsi3);
					Int128* num6 = &int2;
					Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
					*(long*)num6 = struct_fiz2nb11.field_0;
					byte* num7 = (byte*)(&int2) + 8u;
					Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
					*(long*)num7 = struct_fiz2nb12.field_1;
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
						FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_set_uintval.Invoke(&fputil_FPBits_ubgsi3, *(long*)(&int4), ((long*)(&int4))[1]);
						llvm_lifetime_start_p0.Invoke(16L, &num3);
						num3 = FPBits_float128_get_val.Invoke(&fputil_FPBits_ubgsi3);
						result = (((b & 1) == 1) ? ((!FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_is_neg.Invoke(&fputil_FPBits_ubgsi3)) ? (num3 + 1.0) : (num3 - 1.0)) : num3);
						llvm_lifetime_end_p0.Invoke(16L, &num3);
					}
					llvm_lifetime_end_p0.Invoke(16L, &int3);
					llvm_lifetime_end_p0.Invoke(16L, &@int);
					llvm_lifetime_end_p0.Invoke(1L, &b);
					llvm_lifetime_end_p0.Invoke(4L, &num2);
				}
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			return result;
		}
	}
}
