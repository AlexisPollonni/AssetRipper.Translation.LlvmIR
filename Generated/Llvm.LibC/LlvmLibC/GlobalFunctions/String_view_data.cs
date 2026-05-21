using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class String_view_data
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp11string_view4dataEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::data() const")]
	public unsafe static void* Invoke([MangledName("this")] void* This)
	{
		return unchecked((Llvm_libc_20_1_2_cpp_string_view*)This)->Span_data;
	}
}
