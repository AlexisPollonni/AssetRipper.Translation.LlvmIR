using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Reader_getc
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core6Reader4getcEv")]
	[DemangledName("__llvm_libc_20_1_2_::scanf_core::Reader::getc()")]
	public unsafe static sbyte Invoke([MangledName("this")] Scanf_core_Reader* This)
	{
		sbyte b = 0;
		unchecked
		{
			This->Cur_chars_read++;
			sbyte result;
			if (This->Rb != null)
			{
				Llvm_lifetime_start_p0.Invoke(1L, &b);
				b = ((sbyte*)This->Rb->Buffer)[This->Rb->Buff_cur];
				This->Rb->Buff_cur++;
				result = b;
				Llvm_lifetime_end_p0.Invoke(1L, &b);
			}
			else
			{
				result = (sbyte)((delegate*<void*, int>)This->Stream_getc)(This->Input_stream);
			}
			return result;
		}
	}
}
