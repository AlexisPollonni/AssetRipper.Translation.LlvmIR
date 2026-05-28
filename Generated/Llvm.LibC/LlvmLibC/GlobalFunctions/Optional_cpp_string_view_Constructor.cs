using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_cpp_string_view_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS0_11string_viewEEC2EOS2_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::cpp::string_view>::optional(__llvm_libc_20_1_2_::cpp::string_view&&)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("t")][NativeType("__llvm_libc_20_1_2_::cpp::string_view&&")] void* T)
	{
		unchecked
		{
			OptionalStorage_cpp_string_view_false_OptionalStorage_cpp_string_view.Invoke(&((Cpp_optional_bnt67x*)This)->Storage, Cpp_move_cpp_string_view.Invoke(T));
			((Cpp_optional_bnt67x*)This)->Storage.In_use = 1;
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS0_11string_viewEEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::cpp::string_view>::optional()")]
	public unsafe static void Invoke([MangledName("this")] void* This)
	{
		OptionalStorage_cpp_string_view_false_Constructor.Invoke(&unchecked((Cpp_optional_bnt67x*)This)->Storage);
	}
}
