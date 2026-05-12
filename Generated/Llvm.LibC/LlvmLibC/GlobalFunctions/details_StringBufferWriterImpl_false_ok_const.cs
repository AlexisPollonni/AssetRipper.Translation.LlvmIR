using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_7details22StringBufferWriterImplILb0EE2okEv")]
[DemangledName("__llvm_libc_20_1_2_::details::StringBufferWriterImpl<false>::ok() const")]
internal static partial class details_StringBufferWriterImpl_false_ok_const
{
	public unsafe static bool Invoke(details_StringBufferWriterImpl* @this)
	{
		return unchecked((byte)((((@this->out_of_range & 1) == 1) ? 1u : 0u) ^ 0xFFFFFFFFu)) != 0;
	}
}
