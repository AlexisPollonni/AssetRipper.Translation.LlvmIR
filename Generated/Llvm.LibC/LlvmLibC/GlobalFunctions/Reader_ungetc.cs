using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Reader_ungetc
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core6Reader6ungetcEc")]
	[DemangledName("__llvm_libc_20_1_2_::scanf_core::Reader::ungetc(char)")]
	public unsafe static void Invoke(scanf_core_Reader* @this, [NativeType("char")] sbyte c)
	{
		sbyte b = c;
		unchecked
		{
			@this->cur_chars_read += -1L;
			if (@this->rb != null && (ulong)@this->rb->buff_cur > 0uL)
			{
				@this->rb->buff_cur += -1L;
			}
			else
			{
				((delegate*<int, void*, void>)@this->stream_ungetc)(b, @this->input_stream);
			}
		}
	}
}
