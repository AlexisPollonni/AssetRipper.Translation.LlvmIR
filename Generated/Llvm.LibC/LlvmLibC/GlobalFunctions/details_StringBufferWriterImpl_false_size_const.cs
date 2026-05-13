using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_7details22StringBufferWriterImplILb0EE4sizeEv")]
[DemangledName("__llvm_libc_20_1_2_::details::StringBufferWriterImpl<false>::size() const")]
internal static partial class details_StringBufferWriterImpl_false_size_const
{
	public unsafe static long Invoke(details_StringBufferWriterImpl* @this)
	{
		return @this->index;
	}
}
