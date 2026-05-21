using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class string_view_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp11string_viewC2EPKc")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::string_view(char const*)")]
	public unsafe static void Invoke(void* @this, [NativeType("char const*")] void* Str)
	{
		unchecked
		{
			((cpp_string_view*)@this)->span_data = Str;
			((cpp_string_view*)@this)->span_size = string_view_length.Invoke(Str);
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp11string_viewC2EPKcm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::string_view(char const*, unsigned long)")]
	public unsafe static void Invoke(void* @this, [NativeType("char const*")] void* Str, [NativeType("unsigned long")] long N)
	{
		unchecked
		{
			((cpp_string_view*)@this)->span_data = Str;
			((cpp_string_view*)@this)->span_size = N;
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp11string_viewC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::string_view()")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			((cpp_string_view*)@this)->span_data = null;
			((cpp_string_view*)@this)->span_size = 0L;
		}
	}
}
