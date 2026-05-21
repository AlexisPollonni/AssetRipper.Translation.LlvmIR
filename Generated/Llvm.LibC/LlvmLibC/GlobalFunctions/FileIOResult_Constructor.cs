using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FileIOResult_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12FileIOResultC2Em")]
	[DemangledName("__llvm_libc_20_1_2_::FileIOResult::FileIOResult(unsigned long)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_FileIOResult* This, [MangledName("val")][NativeType("unsigned long")] long Val)
	{
		This->Value = Val;
		This->Error = 0;
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_12FileIOResultC2Emi")]
	[DemangledName("__llvm_libc_20_1_2_::FileIOResult::FileIOResult(unsigned long, int)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_FileIOResult* This, [MangledName("val")][NativeType("unsigned long")] long Val, [MangledName("error")][NativeType("int")] int Error)
	{
		This->Value = Val;
		This->Error = Error;
	}
}
