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
			((Llvm_libc_20_1_2_StrToNumResult_cqc3yy*)This)->Value = Value;
			((Llvm_libc_20_1_2_StrToNumResult_cqc3yy*)This)->Error = Error;
			((Llvm_libc_20_1_2_StrToNumResult_cqc3yy*)This)->Parsed_len = Parsed_len;
		}
	}
}
