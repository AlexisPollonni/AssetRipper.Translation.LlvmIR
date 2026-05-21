using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StringBufferWriterImpl_false_size
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_7details22StringBufferWriterImplILb0EE4sizeEv")]
	[DemangledName("__llvm_libc_20_1_2_::details::StringBufferWriterImpl<false>::size() const")]
	public unsafe static long Invoke([MangledName("this")] Llvm_libc_20_1_2_details_StringBufferWriterImpl* This)
	{
		return This->Index;
	}
}
