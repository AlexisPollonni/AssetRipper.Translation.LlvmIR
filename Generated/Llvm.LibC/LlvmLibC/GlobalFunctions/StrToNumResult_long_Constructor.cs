using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_long_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIlEC2Elli")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<long>::StrToNumResult(long, long, int)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("value")][NativeType("long")] long Value, [MangledName("parsed_len")][NativeType("long")] long Parsed_len, [MangledName("error")][NativeType("int")] int Error)
	{
		unchecked
		{
			((StrToNumResult_gbeb3a*)This)->Value = Value;
			((StrToNumResult_gbeb3a*)This)->Error = Error;
			((StrToNumResult_gbeb3a*)This)->Parsed_len = Parsed_len;
		}
	}
}
