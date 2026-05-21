using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_abs_long_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3absIeTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_")]
	[DemangledName("long double __llvm_libc_20_1_2_::fputil::abs<long double, 0>(long double)")]
	[return: NativeType("long double")]
	public unsafe static double Invoke([NativeType("long double")] double x)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
		FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi4, x);
		Struct_fiz2nb struct_fiz2nb = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_abs.Invoke(&fputil_FPBits_ubgsi4);
		Int128* ptr = &fputil_FPBits_ubgsi3.val.Data.FPStorage.field_0;
		Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
		unchecked
		{
			((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
			double result = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi3);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			return result;
		}
	}
}
