using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core6Reader6ungetcEc")]
[DemangledName("__llvm_libc_20_1_2_::scanf_core::Reader::ungetc(char)")]
internal static partial class scanf_core_Reader_ungetc_char
{
	public unsafe static void Invoke(void* @this, sbyte c)
	{
		sbyte b = c;
		unchecked
		{
			((scanf_core_Reader*)@this)->cur_chars_read += -1L;
			if (((scanf_core_Reader*)@this)->rb != null && (ulong)((scanf_core_ReadBuffer*)((scanf_core_Reader*)@this)->rb)->buff_cur > 0uL)
			{
				((scanf_core_ReadBuffer*)((scanf_core_Reader*)@this)->rb)->buff_cur += -1L;
			}
			else
			{
				((delegate*<int, void*, void>)((scanf_core_Reader*)@this)->stream_ungetc)(b, ((scanf_core_Reader*)@this)->input_stream);
			}
		}
	}
}
