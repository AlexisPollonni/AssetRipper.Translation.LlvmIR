using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_polyeval_NumberPair_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8polyevalINS_10NumberPairIdEEEENS_3cpp9enable_ifIXgtstT_Lm8EES6_E4typeERKS6_SA_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<(sizeof (__llvm_libc_20_1_2_::NumberPair<double>) > 8ul), __llvm_libc_20_1_2_::NumberPair<double>>::type __llvm_libc_20_1_2_::fputil::polyeval<__llvm_libc_20_1_2_::NumberPair<double>>(__llvm_libc_20_1_2_::NumberPair<double> const&, __llvm_libc_20_1_2_::NumberPair<double> const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<(sizeof (__llvm_libc_20_1_2_::NumberPair<double>) > 8ul), __llvm_libc_20_1_2_::NumberPair<double>>::type")]
	public unsafe static Struct_4ydhja Invoke([NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] NumberPair* parameter_0, [NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] NumberPair* a0)
	{
		NumberPair numberPair = default(NumberPair);
		llvm_memcpy_p0_p0_i64.Invoke(&numberPair, a0, 16L, isVolatile: false);
		return *unchecked((Struct_4ydhja*)(&numberPair));
	}
}
