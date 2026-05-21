using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_get_upper_bound_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal15get_upper_boundIeEEiv")]
	[DemangledName("int __llvm_libc_20_1_2_::internal::get_upper_bound<long double>()")]
	[return: NativeType("int")]
	public static int Invoke()
	{
		return 5461;
	}
}
