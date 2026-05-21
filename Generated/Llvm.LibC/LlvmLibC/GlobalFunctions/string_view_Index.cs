using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class string_view_Index
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp11string_viewixEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::operator[](unsigned long) const")]
	public unsafe static void* Invoke(void* @this, [NativeType("unsigned long")] long Index)
	{
		return unchecked((byte*)((cpp_string_view*)@this)->span_data) + Index;
	}
}
