using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12FileIOResultC2Em")]
[DemangledName("__llvm_libc_20_1_2_::FileIOResult::FileIOResult(unsigned long)")]
internal static partial class FileIOResult_FileIOResult_unsigned_long
{
	public unsafe static void Invoke(void* @this, long val)
	{
		unchecked
		{
			((FileIOResult*)@this)->value = val;
			((FileIOResult*)@this)->error = 0;
		}
	}
}
