using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_write_x87_control_word
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal22write_x87_control_wordEt")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::write_x87_control_word(unsigned short)")]
	public unsafe static void Invoke([NativeType("unsigned short")] short w)
	{
		short num = w;
		IntrinsicFunctions.AsmFldcw(&num);
	}
}
