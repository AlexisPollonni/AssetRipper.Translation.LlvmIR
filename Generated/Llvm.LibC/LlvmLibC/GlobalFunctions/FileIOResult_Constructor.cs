using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FileIOResult_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12FileIOResultC2Em")]
	[DemangledName("__llvm_libc_20_1_2_::FileIOResult::FileIOResult(unsigned long)")]
	public unsafe static void Invoke(FileIOResult* @this, [NativeType("unsigned long")] long val)
	{
		@this->value = val;
		@this->error = 0;
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_12FileIOResultC2Emi")]
	[DemangledName("__llvm_libc_20_1_2_::FileIOResult::FileIOResult(unsigned long, int)")]
	public unsafe static void Invoke(FileIOResult* @this, [NativeType("unsigned long")] long val, [NativeType("int")] int error)
	{
		@this->value = val;
		@this->error = error;
	}
}
