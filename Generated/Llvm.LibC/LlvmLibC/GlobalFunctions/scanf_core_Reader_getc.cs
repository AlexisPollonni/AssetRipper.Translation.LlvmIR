using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core6Reader4getcEv")]
[DemangledName("__llvm_libc_20_1_2_::scanf_core::Reader::getc()")]
internal static partial class scanf_core_Reader_getc
{
	public unsafe static sbyte Invoke(void* @this)
	{
		sbyte b = 0;
		unchecked
		{
			((scanf_core_Reader*)@this)->cur_chars_read++;
			sbyte result;
			if (((scanf_core_Reader*)@this)->rb != null)
			{
				llvm_lifetime_start_p0.Invoke(1L, &b);
				b = ((sbyte*)((scanf_core_ReadBuffer*)((scanf_core_Reader*)@this)->rb)->buffer)[((scanf_core_ReadBuffer*)((scanf_core_Reader*)@this)->rb)->buff_cur];
				((scanf_core_ReadBuffer*)((scanf_core_Reader*)@this)->rb)->buff_cur++;
				result = b;
				llvm_lifetime_end_p0.Invoke(1L, &b);
			}
			else
			{
				result = (sbyte)((delegate*<void*, int>)((scanf_core_Reader*)@this)->stream_getc)(((scanf_core_Reader*)@this)->input_stream);
			}
			return result;
		}
	}
}
