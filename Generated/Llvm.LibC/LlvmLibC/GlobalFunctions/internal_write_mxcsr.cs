using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_write_mxcsr
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal11write_mxcsrEj")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::write_mxcsr(unsigned int)")]
	public unsafe static void Invoke([NativeType("unsigned int")] int w)
	{
		int num = w;
		IntrinsicFunctions.AsmLdmxcsr(&num);
	}
}
