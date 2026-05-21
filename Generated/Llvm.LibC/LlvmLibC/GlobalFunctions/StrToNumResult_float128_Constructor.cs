using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_float128_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIgEC2Egli")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<__float128>::StrToNumResult(__float128, long, int)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_StrToNumResult_c5b6ms* This, [MangledName("value")][NativeType("__float128")] double Value, [MangledName("parsed_len")][NativeType("long")] long Parsed_len, [MangledName("error")][NativeType("int")] int Error)
	{
		This->Value = Value;
		This->Error = Error;
		This->Parsed_len = Parsed_len;
	}
}
