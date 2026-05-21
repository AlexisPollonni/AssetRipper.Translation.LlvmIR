using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class string_view_empty
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp11string_view5emptyEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::empty() const")]
	public unsafe static bool Invoke(void* @this)
	{
		return unchecked((cpp_string_view*)@this)->span_size == 0L;
	}
}
