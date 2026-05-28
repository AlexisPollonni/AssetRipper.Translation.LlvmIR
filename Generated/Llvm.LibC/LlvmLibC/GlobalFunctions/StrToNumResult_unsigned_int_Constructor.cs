using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_unsigned_int_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIjEC2Ejli")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<unsigned int>::StrToNumResult(unsigned int, long, int)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("value")][NativeType("unsigned int")] int Value, [MangledName("parsed_len")][NativeType("long")] long Parsed_len, [MangledName("error")][NativeType("int")] int Error)
	{
		unchecked
		{
			((StrToNumResult_imtnam*)This)->Value = Value;
			((StrToNumResult_imtnam*)This)->Error = Error;
			((StrToNumResult_imtnam*)This)->Parsed_len = Parsed_len;
		}
	}
}
