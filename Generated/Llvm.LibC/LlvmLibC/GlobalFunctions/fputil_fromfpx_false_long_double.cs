using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_fromfpx_false_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7fromfpxILb0EeEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EES4_E4typeES4_ij")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<long double>, long double>::type __llvm_libc_20_1_2_::fputil::fromfpx<false, long double>(long double, int, unsigned int)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<long double>, long double>::type")]
	public unsafe static double Invoke([NativeType("long double")] double x, [NativeType("int")] int rnd, [NativeType("unsigned int")] int width)
	{
		double num = 0.0;
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		llvm_lifetime_start_p0.Invoke(16L, &num);
		num = fputil_fromfp_false_long_double.Invoke(x, rnd, width);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		*unchecked((Int128*)(&fputil_FPBits_ubgsi3)) = -6148914691236517206L;
		FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi3, num);
		if (!FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan.Invoke(&fputil_FPBits_ubgsi3) && NumericHelper.IsUnorderedOrNotEquals(num, x))
		{
			fputil_raise_except_if_required.Invoke(32);
		}
		double result = num;
		llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		llvm_lifetime_end_p0.Invoke(16L, &num);
		return result;
	}
}
