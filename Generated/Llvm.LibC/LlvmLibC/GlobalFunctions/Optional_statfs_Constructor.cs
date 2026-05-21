using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_statfs_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalI6statfsEC2ENS0_9nullopt_tE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<statfs>::optional(__llvm_libc_20_1_2_::cpp::nullopt_t)")]
	public unsafe static void Invoke([MangledName("this")][NativeType("__llvm_libc_20_1_2_::cpp::nullopt_t")] Llvm_libc_20_1_2_cpp_optional_qbe95b* This)
	{
		OptionalStorage_statfs_false_OptionalStorage.Invoke(&This->Storage);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalI6statfsEC2EOS2_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<statfs>::optional(statfs&&)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_cpp_optional_qbe95b* This, [MangledName("t")][NativeType("statfs&&")] Statfs* T)
	{
		OptionalStorage_statfs_false_OptionalStorage_statfs.Invoke(&This->Storage, Cpp_move_statfs.Invoke(T));
		This->Storage.In_use = 1;
	}
}
