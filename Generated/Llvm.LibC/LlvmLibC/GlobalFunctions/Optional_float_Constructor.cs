using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_float_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIfEC2ENS0_9nullopt_tE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<float>::optional(__llvm_libc_20_1_2_::cpp::nullopt_t)")]
	public unsafe static void Invoke([MangledName("this")][NativeType("__llvm_libc_20_1_2_::cpp::nullopt_t")] Cpp_optional_xmxtsi* This)
	{
		OptionalStorage_float_false_OptionalStorage.Invoke(&This->Storage);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIfEC2EOf")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<float>::optional(float&&)")]
	public unsafe static void Invoke([MangledName("this")] Cpp_optional_xmxtsi* This, [MangledName("t")][NativeType("float&&")] void* T)
	{
		OptionalStorage_float_false_OptionalStorage_float.Invoke(&This->Storage, Cpp_move_float.Invoke(T));
		This->Storage.In_use = 1;
	}
}
