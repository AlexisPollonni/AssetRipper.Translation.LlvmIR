using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12FileIOResultC2Emi")]
[DemangledName("__llvm_libc_20_1_2_::FileIOResult::FileIOResult(unsigned long, int)")]
internal static partial class FileIOResult_FileIOResult_unsigned_long_int
{
	public unsafe static void Invoke(void* @this, long val, int error)
	{
		unchecked
		{
			((FileIOResult*)@this)->value = val;
			((FileIOResult*)@this)->error = error;
		}
	}
}
