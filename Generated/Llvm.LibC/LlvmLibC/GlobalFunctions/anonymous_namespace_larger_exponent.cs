using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class anonymous_namespace_larger_exponent
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_115larger_exponentEdd")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::larger_exponent(double, double)")]
	public unsafe static bool Invoke([NativeType("double")] double a, [NativeType("double")] double b)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2, a);
		unchecked
		{
			ushort num = (ushort)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm3, b);
			bool result = num >= (ushort)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3));
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			return result;
		}
	}
}
