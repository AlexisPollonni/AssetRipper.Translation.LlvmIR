using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_unsigned_short_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultItEC2Etli")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<unsigned short>::StrToNumResult(unsigned short, long, int)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("value")][NativeType("unsigned short")] short Value, [MangledName("parsed_len")][NativeType("long")] long Parsed_len, [MangledName("error")][NativeType("int")] int Error)
	{
		short value = Value;
		unchecked
		{
			((Llvm_libc_20_1_2_StrToNumResult_wwcts2*)This)->Value = value;
			((Llvm_libc_20_1_2_StrToNumResult_wwcts2*)This)->Error = Error;
			((Llvm_libc_20_1_2_StrToNumResult_wwcts2*)This)->Parsed_len = Parsed_len;
		}
	}
}
