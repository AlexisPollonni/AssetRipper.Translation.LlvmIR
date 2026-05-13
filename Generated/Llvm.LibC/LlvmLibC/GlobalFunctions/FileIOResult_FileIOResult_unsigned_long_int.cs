using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12FileIOResultC2Emi")]
[DemangledName("__llvm_libc_20_1_2_::FileIOResult::FileIOResult(unsigned long, int)")]
internal static partial class FileIOResult_FileIOResult_unsigned_long_int
{
	public unsafe static void Invoke(FileIOResult* @this, long val, int error)
	{
		@this->value = val;
		@this->error = error;
	}
}
