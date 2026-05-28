using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_double_has_error
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIdE9has_errorEv")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<double>::has_error()")]
	public unsafe static bool Invoke([MangledName("this")] StrToNumResult_k826n6* This)
	{
		return This->Error != 0;
	}
}
