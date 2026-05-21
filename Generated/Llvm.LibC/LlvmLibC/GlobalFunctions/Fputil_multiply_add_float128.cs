using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_multiply_add_float128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12multiply_addIgEENS_3cpp9enable_ifIXgtstT_Lm8EES4_E4typeERKS4_S8_S8_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<(sizeof (__float128) > 8ul), __float128>::type __llvm_libc_20_1_2_::fputil::multiply_add<__float128>(__float128 const&, __float128 const&, __float128 const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<(sizeof (__float128) > 8ul), __float128>::type")]
	public unsafe static double Invoke([MangledName("x")][NativeType("__float128 const&")] void* X, [MangledName("y")][NativeType("__float128 const&")] void* Y, [MangledName("z")][NativeType("__float128 const&")] void* Z)
	{
		return unchecked(Llvm_fmuladd_f128.Invoke(*(double*)X, *(double*)Y, *(double*)Z));
	}
}
