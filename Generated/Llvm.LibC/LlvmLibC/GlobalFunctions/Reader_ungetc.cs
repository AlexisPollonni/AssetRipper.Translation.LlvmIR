using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Reader_ungetc
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core6Reader6ungetcEc")]
	[DemangledName("__llvm_libc_20_1_2_::scanf_core::Reader::ungetc(char)")]
	public unsafe static void Invoke([MangledName("this")] Scanf_core_Reader* This, [MangledName("c")][NativeType("char")] sbyte C)
	{
		sbyte b = C;
		unchecked
		{
			This->Cur_chars_read += -1L;
			if (This->Rb != null && (ulong)This->Rb->Buff_cur > 0uL)
			{
				This->Rb->Buff_cur += -1L;
			}
			else
			{
				((delegate*<int, void*, void>)This->Stream_ungetc)(b, This->Input_stream);
			}
		}
	}
}
