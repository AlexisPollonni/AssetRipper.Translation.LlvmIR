using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_Float16_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIDF16_EC2EDF16_li")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<_Float16>::StrToNumResult(_Float16, long, int)")]
	public unsafe static void Invoke(StrToNumResult_stcih6* @this, [NativeType("_Float16")] Half value, [NativeType("long")] long parsed_len, [NativeType("int")] int error)
	{
		@this->value = value;
		@this->error = error;
		@this->parsed_len = parsed_len;
	}
}
