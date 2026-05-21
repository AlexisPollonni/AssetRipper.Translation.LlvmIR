using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_statfs_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalI6statfsEC2ENS0_9nullopt_tE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<statfs>::optional(__llvm_libc_20_1_2_::cpp::nullopt_t)")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::nullopt_t")] cpp_optional_qbe95b* @this)
	{
		OptionalStorage_statfs_false_OptionalStorage.Invoke(&@this->storage);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalI6statfsEC2EOS2_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<statfs>::optional(statfs&&)")]
	public unsafe static void Invoke(cpp_optional_qbe95b* @this, [NativeType("statfs&&")] statfs* t)
	{
		OptionalStorage_statfs_false_OptionalStorage_statfs.Invoke(&@this->storage, cpp_move_statfs.Invoke(t));
		@this->storage.in_use = 1;
	}
}
