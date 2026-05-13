using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal11write_mxcsrEj")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::write_mxcsr(unsigned int)")]
internal static partial class fputil_internal_write_mxcsr_unsigned_int
{
	public unsafe static void Invoke(int w)
	{
		int num = w;
		IntrinsicFunctions.AsmLdmxcsr(&num);
	}
}
