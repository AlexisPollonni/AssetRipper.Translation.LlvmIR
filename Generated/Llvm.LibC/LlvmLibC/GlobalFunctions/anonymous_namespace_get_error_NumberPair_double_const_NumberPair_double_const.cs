using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_19get_errorERKNS_10NumberPairIdEES4_")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::get_error(__llvm_libc_20_1_2_::NumberPair<double> const&, __llvm_libc_20_1_2_::NumberPair<double> const&)")]
internal static partial class anonymous_namespace_get_error_NumberPair_double_const_NumberPair_double_const
{
	public unsafe static double Invoke(void* x_3, void* a_sq)
	{
		return unchecked(fputil_multiply_add_double_double_double.Invoke(((NumberPair*)x_3)->hi, ((NumberPair*)a_sq)->hi, -1.0) + fputil_multiply_add_double_double_double.Invoke(((NumberPair*)x_3)->lo, ((NumberPair*)a_sq)->hi, ((NumberPair*)x_3)->hi * ((NumberPair*)a_sq)->lo));
	}
}
