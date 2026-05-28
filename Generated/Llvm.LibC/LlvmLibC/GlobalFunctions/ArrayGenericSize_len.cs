using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ArrayGenericSize_len
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_8internal16ArrayGenericSize3lenEv")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ArrayGenericSize::len() const")]
	public unsafe static long Invoke([MangledName("this")] void* This)
	{
		return unchecked((Scanf_core_ReadBuffer*)This)->Buff_len;
	}
}
