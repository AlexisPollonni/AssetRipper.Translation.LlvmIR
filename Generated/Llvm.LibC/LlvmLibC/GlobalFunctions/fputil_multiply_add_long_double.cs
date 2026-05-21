using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_multiply_add_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12multiply_addIeEENS_3cpp9enable_ifIXgtstT_Lm8EES4_E4typeERKS4_S8_S8_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<(sizeof (long double) > 8ul), long double>::type __llvm_libc_20_1_2_::fputil::multiply_add<long double>(long double const&, long double const&, long double const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<(sizeof (long double) > 8ul), long double>::type")]
	public unsafe static double Invoke([NativeType("long double const&")] void* x, [NativeType("long double const&")] void* y, [NativeType("long double const&")] void* z)
	{
		return unchecked(llvm_fmuladd_f80.Invoke(*(double*)x, *(double*)y, *(double*)z));
	}
}
