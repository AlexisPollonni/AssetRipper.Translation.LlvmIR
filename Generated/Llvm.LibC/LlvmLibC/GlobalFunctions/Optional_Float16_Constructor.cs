using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_Float16_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIDF16_EC2ENS0_9nullopt_tE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<_Float16>::optional(__llvm_libc_20_1_2_::cpp::nullopt_t)")]
	public unsafe static void Invoke([MangledName("this")][NativeType("__llvm_libc_20_1_2_::cpp::nullopt_t")] Llvm_libc_20_1_2_cpp_optional_aq7wey* This)
	{
		OptionalStorage_Float16_false_OptionalStorage.Invoke(&This->Storage);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIDF16_EC2EODF16_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<_Float16>::optional(_Float16&&)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_cpp_optional_aq7wey* This, [MangledName("t")][NativeType("_Float16&&")] void* T)
	{
		OptionalStorage_Float16_false_OptionalStorage_Float16.Invoke(&This->Storage, Cpp_move_Float16.Invoke(T));
		This->Storage.In_use = 1;
	}
}
