using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StringBufferWriterImpl_false_ok
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_7details22StringBufferWriterImplILb0EE2okEv")]
	[DemangledName("__llvm_libc_20_1_2_::details::StringBufferWriterImpl<false>::ok() const")]
	public unsafe static bool Invoke([MangledName("this")] Llvm_libc_20_1_2_details_StringBufferWriterImpl* This)
	{
		return InstructionHelper.BooleanXor((This->Out_of_range & 1) == 1, right: true);
	}
}
