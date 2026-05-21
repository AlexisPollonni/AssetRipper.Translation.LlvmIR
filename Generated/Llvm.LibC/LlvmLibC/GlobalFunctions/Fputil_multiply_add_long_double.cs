using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_multiply_add_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12multiply_addIeEENS_3cpp9enable_ifIXgtstT_Lm8EES4_E4typeERKS4_S8_S8_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<(sizeof (long double) > 8ul), long double>::type __llvm_libc_20_1_2_::fputil::multiply_add<long double>(long double const&, long double const&, long double const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<(sizeof (long double) > 8ul), long double>::type")]
	public unsafe static double Invoke([MangledName("x")][NativeType("long double const&")] void* X, [MangledName("y")][NativeType("long double const&")] void* Y, [MangledName("z")][NativeType("long double const&")] void* Z)
	{
		return unchecked(Llvm_fmuladd_f80.Invoke(*(double*)X, *(double*)Y, *(double*)Z));
	}
}
