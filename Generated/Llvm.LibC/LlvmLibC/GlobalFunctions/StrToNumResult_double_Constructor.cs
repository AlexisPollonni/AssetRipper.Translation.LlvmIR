using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_double_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIdEC2Edli")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<double>::StrToNumResult(double, long, int)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_StrToNumResult_k826n6* This, [MangledName("value")][NativeType("double")] double Value, [MangledName("parsed_len")][NativeType("long")] long Parsed_len, [MangledName("error")][NativeType("int")] int Error)
	{
		This->Value = Value;
		This->Error = Error;
		This->Parsed_len = Parsed_len;
	}
}
