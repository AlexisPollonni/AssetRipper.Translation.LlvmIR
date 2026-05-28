using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_statfs_false_OptionalStorage_statfs
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalI6statfsE15OptionalStorageIS2_Lb0EEC2IJS2_EEENS0_10in_place_tEDpOT_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<statfs>::OptionalStorage<statfs, false>::OptionalStorage<statfs>(__llvm_libc_20_1_2_::cpp::in_place_t, statfs&&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::optional")]
	public unsafe static void Invoke([MangledName("this")][NativeType("__llvm_libc_20_1_2_::cpp::in_place_t")] Cpp_optional_statfs_OptionalStorage* This, [MangledName("args")][NativeType("statfs&&")] void* Args)
	{
		Llvm_memcpy_p0_p0_i64.Invoke(&This->field, Cpp_forward_statfs.Invoke(unchecked((Statfs*)Args)), 120L, isVolatile: false);
		This->In_use = 0;
	}
}
