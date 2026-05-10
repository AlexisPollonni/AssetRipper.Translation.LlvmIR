using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_115larger_exponentEdd")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::larger_exponent(double, double)")]
internal static partial class anonymous_namespace_larger_exponent_double_double
{
	public unsafe static bool Invoke(double a, double b)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm2, a);
		unchecked
		{
			ushort num = (ushort)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent_const.Invoke(&fputil_FPBits_wjhbrm2);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm3, b);
			bool result = num >= (ushort)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent_const.Invoke(&fputil_FPBits_wjhbrm3);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			return result;
		}
	}
}
