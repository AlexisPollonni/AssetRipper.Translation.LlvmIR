using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_float_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIfEC2ENS0_9nullopt_tE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<float>::optional(__llvm_libc_20_1_2_::cpp::nullopt_t)")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::nullopt_t")] cpp_optional_xmxtsi* @this)
	{
		OptionalStorage_float_false_OptionalStorage.Invoke(&@this->storage);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIfEC2EOf")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<float>::optional(float&&)")]
	public unsafe static void Invoke(cpp_optional_xmxtsi* @this, [NativeType("float&&")] void* t)
	{
		OptionalStorage_float_false_OptionalStorage_float.Invoke(&@this->storage, cpp_move_float.Invoke(t));
		@this->storage.in_use = 1;
	}
}
