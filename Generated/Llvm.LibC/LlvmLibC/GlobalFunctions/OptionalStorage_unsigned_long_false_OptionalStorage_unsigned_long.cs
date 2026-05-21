using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_unsigned_long_false_OptionalStorage_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalImE15OptionalStorageImLb0EEC2IJmEEENS0_10in_place_tEDpOT_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<unsigned long>::OptionalStorage<unsigned long, false>::OptionalStorage<unsigned long>(__llvm_libc_20_1_2_::cpp::in_place_t, unsigned long&&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::optional")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::in_place_t")] void* @this, [NativeType("unsigned long&&")] void* args)
	{
		unchecked
		{
			fputil_internal_FPStorage_v3nexn* field = &((cpp_expected*)@this)->field;
			*(long*)field = *(long*)cpp_forward_unsigned_long.Invoke(args);
			((cpp_expected*)@this)->in_use = 0;
		}
	}
}
