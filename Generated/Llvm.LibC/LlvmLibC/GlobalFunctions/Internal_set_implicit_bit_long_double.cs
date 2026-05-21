using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_set_implicit_bit_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal16set_implicit_bitIeEEvRNS_6fputil6FPBitsIT_EE")]
	[DemangledName("void __llvm_libc_20_1_2_::internal::set_implicit_bit<long double>(__llvm_libc_20_1_2_::fputil::FPBits<long double>&)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([MangledName("result")][NativeType("__llvm_libc_20_1_2_::fputil::FPBits<long double>&")] void* Result)
	{
		FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_set_implicit_bit.Invoke(Result, unchecked((ushort)FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_biased_exponent.Invoke(Result)) != 0);
	}
}
