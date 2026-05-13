using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIeE15OptionalStorageIeLb0EEC2IJeEEENS0_10in_place_tEDpOT_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<long double>::OptionalStorage<long double, false>::OptionalStorage<long double>(__llvm_libc_20_1_2_::cpp::in_place_t, long double&&)")]
internal static partial class cpp_optional_long_double_OptionalStorage_long_double_false_OptionalStorage_long_double_cpp_in_place_t_long_double
{
	public unsafe static void Invoke(void* @this, void* args)
	{
		unchecked
		{
			anon_mbc8w5* field = &((cpp_optional_long_double_OptionalStorage*)@this)->field;
			*(double*)field = *(double*)long_double_cpp_forward_long_double_cpp_remove_reference_long_double_type.Invoke(args);
			((cpp_optional_long_double_OptionalStorage*)@this)->field_1 = 0;
		}
	}
}
