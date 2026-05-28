using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ArrayFixedSize_4ul_len
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_8internal14ArrayFixedSizeILm4EE3lenEv")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ArrayFixedSize<4ul>::len() const")]
	public unsafe static long Invoke([MangledName("this")] void* This)
	{
		return unchecked((Cpp_string_view*)This)->Span_size;
	}
}
