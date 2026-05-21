using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_cpp_string_view_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS0_11string_viewEEC2EOS2_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::cpp::string_view>::optional(__llvm_libc_20_1_2_::cpp::string_view&&)")]
	public unsafe static void Invoke(void* @this, [NativeType("__llvm_libc_20_1_2_::cpp::string_view&&")] void* t)
	{
		unchecked
		{
			OptionalStorage_cpp_string_view_false_OptionalStorage_cpp_string_view.Invoke(&((cpp_optional_bnt67x*)@this)->storage, cpp_move_cpp_string_view.Invoke(t));
			((cpp_optional_bnt67x*)@this)->storage.in_use = 1;
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS0_11string_viewEEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::cpp::string_view>::optional()")]
	public unsafe static void Invoke(void* @this)
	{
		OptionalStorage_cpp_string_view_false_Constructor.Invoke(&unchecked((cpp_optional_bnt67x*)@this)->storage);
	}
}
