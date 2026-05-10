using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIdE15OptionalStorageIdLb0EEC2IJdEEENS0_10in_place_tEDpOT_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<double>::OptionalStorage<double, false>::OptionalStorage<double>(__llvm_libc_20_1_2_::cpp::in_place_t, double&&)")]
internal static partial class cpp_optional_double_OptionalStorage_double_false_OptionalStorage_double_cpp_in_place_t_double
{
	public unsafe static void Invoke(void* @this, void* args)
	{
		unchecked
		{
			anon_6i3r2b* field = &((cpp_optional_double_OptionalStorage*)@this)->field;
			*(double*)field = *(double*)double_cpp_forward_double_cpp_remove_reference_double_type.Invoke(args);
			((cpp_optional_double_OptionalStorage*)@this)->in_use = 0;
		}
	}
}
