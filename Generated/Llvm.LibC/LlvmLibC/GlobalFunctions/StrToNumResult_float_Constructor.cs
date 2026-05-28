using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_float_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIfEC2Efli")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<float>::StrToNumResult(float, long, int)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("value")][NativeType("float")] float Value, [MangledName("parsed_len")][NativeType("long")] long Parsed_len, [MangledName("error")][NativeType("int")] int Error)
	{
		unchecked
		{
			((StrToNumResult_cqc3yy*)This)->Value = Value;
			((StrToNumResult_cqc3yy*)This)->Error = Error;
			((StrToNumResult_cqc3yy*)This)->Parsed_len = Parsed_len;
		}
	}
}
