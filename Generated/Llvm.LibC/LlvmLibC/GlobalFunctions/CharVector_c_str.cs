using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class CharVector_c_str
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10CharVector5c_strEv")]
	[DemangledName("__llvm_libc_20_1_2_::CharVector::c_str()")]
	public unsafe static void* Invoke([MangledName("this")] CharVector* This)
	{
		unchecked((sbyte*)This->Cur_str)[This->Index] = 0;
		return This->Cur_str;
	}
}
