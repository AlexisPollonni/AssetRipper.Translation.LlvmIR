using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Anonymous_namespace_larger_exponent
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_115larger_exponentEdd")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::larger_exponent(double, double)")]
	public unsafe static bool Invoke([MangledName("a")][NativeType("double")] double A, [MangledName("b")][NativeType("double")] double B)
	{
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(Fputil_FPBits_wjhbrm);
		Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm, A);
		unchecked
		{
			ushort num = (ushort)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm));
			Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2, B);
			bool result = num >= (ushort)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
			return result;
		}
	}
}
