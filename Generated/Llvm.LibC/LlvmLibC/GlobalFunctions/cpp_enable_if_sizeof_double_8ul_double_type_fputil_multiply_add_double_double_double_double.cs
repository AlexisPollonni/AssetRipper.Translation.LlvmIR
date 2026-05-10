using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12multiply_addIdEENS_3cpp9enable_ifIXlestT_Lm8EES4_E4typeES4_S4_S4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (double) <= 8ul, double>::type __llvm_libc_20_1_2_::fputil::multiply_add<double>(double, double, double)")]
internal static partial class cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double
{
	public static double Invoke(double x, double y, double z)
	{
		return llvm_fmuladd_f64.Invoke(x, y, z);
	}
}
