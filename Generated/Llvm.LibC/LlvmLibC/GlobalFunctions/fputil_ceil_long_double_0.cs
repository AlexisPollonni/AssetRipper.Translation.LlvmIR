using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_ceil_long_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4ceilIeTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_")]
	[DemangledName("long double __llvm_libc_20_1_2_::fputil::ceil<long double, 0>(long double)")]
	[return: NativeType("long double")]
	public unsafe static double Invoke([NativeType("long double")] double x)
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
			FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi3, x);
			double result;
			if (FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_inf_or_nan.Invoke(&fputil_FPBits_ubgsi3) || FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero.Invoke(&fputil_FPBits_ubgsi3))
			{
				result = x;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(1L, &b);
				b = (FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_neg.Invoke(&fputil_FPBits_ubgsi3) ? ((sbyte)1) : ((sbyte)0));
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_exponent.Invoke(&fputil_FPBits_ubgsi3);
				if (num >= 63)
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
					num2 = checked(63 - num);
					llvm_lifetime_start_p0.Invoke(16L, &@int);
					Struct_fiz2nb struct_fiz2nb = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_uintval.Invoke(&fputil_FPBits_ubgsi3);
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
						FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_uintval.Invoke(&fputil_FPBits_ubgsi3, *(long*)(&int4), ((long*)(&int4))[1]);
						llvm_lifetime_start_p0.Invoke(16L, &num3);
						num3 = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi3);
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
