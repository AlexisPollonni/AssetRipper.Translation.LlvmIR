using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_fromfpx_true_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7fromfpxILb1EdEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EES4_E4typeES4_ij")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double>, double>::type __llvm_libc_20_1_2_::fputil::fromfpx<true, double>(double, int, unsigned int)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double>, double>::type")]
	public unsafe static double Invoke([NativeType("double")] double x, [NativeType("int")] int rnd, [NativeType("unsigned int")] int width)
	{
		double num = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = fputil_fromfp_true_double.Invoke(x, rnd, width);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2, num);
			if (!FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)) && NumericHelper.IsUnorderedOrNotEquals(num, x))
			{
				fputil_raise_except_if_required.Invoke(32);
			}
			double result = num;
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
