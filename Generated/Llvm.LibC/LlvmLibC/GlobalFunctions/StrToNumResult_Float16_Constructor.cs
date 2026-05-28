using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_Float16_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIDF16_EC2EDF16_li")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<_Float16>::StrToNumResult(_Float16, long, int)")]
	public unsafe static void Invoke([MangledName("this")] StrToNumResult_stcih6* This, [MangledName("value")][NativeType("_Float16")] Half Value, [MangledName("parsed_len")][NativeType("long")] long Parsed_len, [MangledName("error")][NativeType("int")] int Error)
	{
		This->Value = Value;
		This->Error = Error;
		This->Parsed_len = Parsed_len;
	}
}
