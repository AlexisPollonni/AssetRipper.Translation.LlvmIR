using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_statfs_false_OptionalStorage_statfs
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalI6statfsE15OptionalStorageIS2_Lb0EEC2IJS2_EEENS0_10in_place_tEDpOT_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<statfs>::OptionalStorage<statfs, false>::OptionalStorage<statfs>(__llvm_libc_20_1_2_::cpp::in_place_t, statfs&&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::optional")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::in_place_t")] cpp_optional_statfs_OptionalStorage* @this, [NativeType("statfs&&")] void* args)
	{
		llvm_memcpy_p0_p0_i64.Invoke(&@this->field, cpp_forward_statfs.Invoke(unchecked((statfs*)args)), 120L, isVolatile: false);
		@this->in_use = 0;
	}
}
