using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_float_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIfEC2Efli")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<float>::StrToNumResult(float, long, int)")]
	public unsafe static void Invoke(void* @this, [NativeType("float")] float value, [NativeType("long")] long parsed_len, [NativeType("int")] int error)
	{
		unchecked
		{
			((StrToNumResult_cqc3yy*)@this)->value = value;
			((StrToNumResult_cqc3yy*)@this)->error = error;
			((StrToNumResult_cqc3yy*)@this)->parsed_len = parsed_len;
		}
	}
}
