using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class String_view_size
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp11string_view4sizeEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::size() const")]
	public unsafe static long Invoke([MangledName("this")] void* This)
	{
		return unchecked((Llvm_libc_20_1_2_cpp_string_view*)This)->Span_size;
	}
}
