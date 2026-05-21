using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_float128_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIgEC2Egli")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<__float128>::StrToNumResult(__float128, long, int)")]
	public unsafe static void Invoke(StrToNumResult_c5b6ms* @this, [NativeType("__float128")] double value, [NativeType("long")] long parsed_len, [NativeType("int")] int error)
	{
		@this->value = value;
		@this->error = error;
		@this->parsed_len = parsed_len;
	}
}
