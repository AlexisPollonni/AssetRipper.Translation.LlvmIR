using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_4File10adjust_bufEv")]
[DemangledName("__llvm_libc_20_1_2_::File::adjust_buf()")]
internal static partial class File_adjust_buf
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			if (File_read_allowed_const.Invoke(@this) && (((File_sjnxn4*)@this)->buf == null || ((File_sjnxn4*)@this)->bufsize == 0L))
			{
				((File_sjnxn4*)@this)->buf = &((File_sjnxn4*)@this)->ungetc_buf;
				((File_sjnxn4*)@this)->bufsize = 1L;
				((File_sjnxn4*)@this)->own_buf = 0;
			}
		}
	}
}
