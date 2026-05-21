using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_set_implicit_bit_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal16set_implicit_bitIfEEvRNS_6fputil6FPBitsIT_EE")]
	[DemangledName("void __llvm_libc_20_1_2_::internal::set_implicit_bit<float>(__llvm_libc_20_1_2_::fputil::FPBits<float>&)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::fputil::FPBits<float>&")] Llvm_libc_20_1_2_fputil_FPBits_5nkvcs* parameter_0)
	{
	}
}
