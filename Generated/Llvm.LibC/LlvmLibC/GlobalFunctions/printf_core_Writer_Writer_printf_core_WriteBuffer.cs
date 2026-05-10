using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6WriterC2EPNS0_11WriteBufferE")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::Writer::Writer(__llvm_libc_20_1_2_::printf_core::WriteBuffer*)")]
internal static partial class printf_core_Writer_Writer_printf_core_WriteBuffer
{
	public unsafe static void Invoke(void* @this, void* WB)
	{
		unchecked
		{
			((printf_core_Writer*)@this)->wb = WB;
			((printf_core_Writer*)@this)->chars_written = 0;
		}
	}
}
