using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalImE15OptionalStorageImLb0EEC2IJmEEENS0_10in_place_tEDpOT_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<unsigned long>::OptionalStorage<unsigned long, false>::OptionalStorage<unsigned long>(__llvm_libc_20_1_2_::cpp::in_place_t, unsigned long&&)")]
internal static partial class cpp_optional_unsigned_long_OptionalStorage_unsigned_long_false_OptionalStorage_unsigned_long_cpp_in_place_t_unsigned_long
{
	public unsafe static void Invoke(void* @this, void* args)
	{
		unchecked
		{
			fputil_internal_FPStorage_v3nexn* field = &((cpp_expected*)@this)->field;
			*(long*)field = *(long*)unsigned_long_cpp_forward_unsigned_long_cpp_remove_reference_unsigned_long_type.Invoke(args);
			((cpp_expected*)@this)->in_use = 0;
		}
	}
}
