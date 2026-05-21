using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_fminimum_num_long_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12fminimum_numIeTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_S4_")]
	[DemangledName("long double __llvm_libc_20_1_2_::fputil::fminimum_num<long double, 0>(long double, long double)")]
	[return: NativeType("long double")]
	public unsafe static double Invoke([NativeType("long double")] double x, [NativeType("long double")] double y)
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
			FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi3, x);
			llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			*(Int128*)(&fputil_FPBits_ubgsi4) = -6148914691236517206L;
			FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi4, y);
			if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_signaling_nan.Invoke(&fputil_FPBits_ubgsi3) || FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_signaling_nan.Invoke(&fputil_FPBits_ubgsi4))
			{
				fputil_raise_except_if_required.Invoke(1);
				if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan.Invoke(&fputil_FPBits_ubgsi3) && FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan.Invoke(&fputil_FPBits_ubgsi4))
				{
					llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
					sbyte val = anon_izyfb8.val;
					@int = 0L;
					Struct_fiz2nb struct_fiz2nb = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_quiet_nan.Invoke(val, *(long*)(&@int), ((long*)(&@int))[1]);
					Int128* ptr = &fputil_FPBits_ubgsi5.val.Data.FPStorage.field_0;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
					result = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi5);
					llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
					goto IL_01ad;
				}
			}
			result = ((!FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan.Invoke(&fputil_FPBits_ubgsi3)) ? ((!FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan.Invoke(&fputil_FPBits_ubgsi4)) ? internal_min_long_double.Invoke(x, y) : x) : y);
			goto IL_01ad;
		}
		IL_01ad:
		llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
		llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		return result;
	}
}
