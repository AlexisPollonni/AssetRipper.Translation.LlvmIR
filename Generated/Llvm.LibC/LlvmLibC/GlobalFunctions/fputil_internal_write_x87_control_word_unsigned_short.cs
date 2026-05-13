using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal22write_x87_control_wordEt")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::write_x87_control_word(unsigned short)")]
internal static partial class fputil_internal_write_x87_control_word_unsigned_short
{
	public unsafe static void Invoke(short w)
	{
		short num = w;
		IntrinsicFunctions.AsmFldcw(&num);
	}
}
