using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_fromfpx_false_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7fromfpxILb0EeEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EES4_E4typeES4_ij")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<long double>, long double>::type __llvm_libc_20_1_2_::fputil::fromfpx<false, long double>(long double, int, unsigned int)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<long double>, long double>::type")]
	public unsafe static double Invoke([MangledName("x")][NativeType("long double")] double X, [MangledName("rnd")][NativeType("int")] int Rnd, [MangledName("width")][NativeType("unsigned int")] int Width)
	{
		double num = 0.0;
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi = default(Fputil_FPBits_ubgsi2);
		Llvm_lifetime_start_p0.Invoke(16L, &num);
		num = Fputil_fromfp_false_long_double.Invoke(X, Rnd, Width);
		Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi);
		*unchecked((Int128*)(&fputil_FPBits_ubgsi)) = -6148914691236517206L;
		FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi, num);
		if (!FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan.Invoke(&fputil_FPBits_ubgsi) && NumericHelper.IsUnorderedOrNotEquals(num, X))
		{
			Fputil_raise_except_if_required.Invoke(32);
		}
		double result = num;
		Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi);
		Llvm_lifetime_end_p0.Invoke(16L, &num);
		return result;
	}
}
