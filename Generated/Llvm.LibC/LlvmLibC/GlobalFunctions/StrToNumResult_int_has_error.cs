using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_int_has_error
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIiE9has_errorEv")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<int>::has_error()")]
	public unsafe static bool Invoke([MangledName("this")] void* This)
	{
		return unchecked((StrToNumResult_imtnam*)This)->Error != 0;
	}
}
