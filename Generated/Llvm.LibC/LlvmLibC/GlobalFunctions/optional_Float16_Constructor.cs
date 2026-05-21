using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_Float16_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIDF16_EC2ENS0_9nullopt_tE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<_Float16>::optional(__llvm_libc_20_1_2_::cpp::nullopt_t)")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::nullopt_t")] cpp_optional_aq7wey* @this)
	{
		OptionalStorage_Float16_false_OptionalStorage.Invoke(&@this->storage);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIDF16_EC2EODF16_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<_Float16>::optional(_Float16&&)")]
	public unsafe static void Invoke(cpp_optional_aq7wey* @this, [NativeType("_Float16&&")] void* t)
	{
		OptionalStorage_Float16_false_OptionalStorage_Float16.Invoke(&@this->storage, cpp_move_Float16.Invoke(t));
		@this->storage.in_use = 1;
	}
}
