using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_float_ToSingle
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIfEcvfEv")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<float>::operator float()")]
	public unsafe static float Invoke([MangledName("this")] void* This)
	{
		return unchecked((StrToNumResult_cqc3yy*)This)->Value;
	}
}
