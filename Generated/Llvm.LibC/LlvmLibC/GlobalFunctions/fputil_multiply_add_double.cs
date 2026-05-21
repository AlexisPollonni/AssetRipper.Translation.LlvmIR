using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_multiply_add_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12multiply_addIdEENS_3cpp9enable_ifIXlestT_Lm8EES4_E4typeES4_S4_S4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (double) <= 8ul, double>::type __llvm_libc_20_1_2_::fputil::multiply_add<double>(double, double, double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (double) <= 8ul, double>::type")]
	public static double Invoke([NativeType("double")] double x, [NativeType("double")] double y, [NativeType("double")] double z)
	{
		return llvm_fmuladd_f64.Invoke(x, y, z);
	}
}
