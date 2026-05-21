using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class String_view_Index
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp11string_viewixEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::operator[](unsigned long) const")]
	public unsafe static void* Invoke([MangledName("this")] void* This, [NativeType("unsigned long")] long Index)
	{
		return unchecked((byte*)((Llvm_libc_20_1_2_cpp_string_view*)This)->Span_data) + Index;
	}
}
