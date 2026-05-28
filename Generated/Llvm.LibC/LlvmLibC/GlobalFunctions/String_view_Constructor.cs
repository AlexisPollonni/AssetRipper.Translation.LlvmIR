using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class String_view_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp11string_viewC2EPKc")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::string_view(char const*)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [NativeType("char const*")] void* Str)
	{
		unchecked
		{
			((Cpp_string_view*)This)->Span_data = Str;
			((Cpp_string_view*)This)->Span_size = String_view_length.Invoke(Str);
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp11string_viewC2EPKcm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::string_view(char const*, unsigned long)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [NativeType("char const*")] void* Str, [NativeType("unsigned long")] long N)
	{
		unchecked
		{
			((Cpp_string_view*)This)->Span_data = Str;
			((Cpp_string_view*)This)->Span_size = N;
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp11string_viewC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::string_view()")]
	public unsafe static void Invoke([MangledName("this")] void* This)
	{
		unchecked
		{
			((Cpp_string_view*)This)->Span_data = null;
			((Cpp_string_view*)This)->Span_size = 0L;
		}
	}
}
