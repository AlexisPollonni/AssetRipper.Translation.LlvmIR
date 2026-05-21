using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class string_view_substr
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp11string_view6substrEmm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::substr(unsigned long, unsigned long) const")]
	public unsafe static Struct_kqhe8i Invoke(void* @this, [NativeType("unsigned long")] long Start, [NativeType("unsigned long")] long N)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		long a = Start;
		unchecked
		{
			a = string_view_min.Invoke(a, ((cpp_string_view*)@this)->span_size);
			string_view_Constructor.Invoke(&cpp_string_view2, (byte*)((cpp_string_view*)@this)->span_data + a, string_view_min.Invoke(N, ((cpp_string_view*)@this)->span_size - a));
			return *(Struct_kqhe8i*)(&cpp_string_view2);
		}
	}
}
