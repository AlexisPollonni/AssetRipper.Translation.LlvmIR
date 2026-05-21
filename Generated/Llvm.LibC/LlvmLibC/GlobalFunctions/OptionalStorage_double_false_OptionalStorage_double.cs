using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_double_false_OptionalStorage_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIdE15OptionalStorageIdLb0EEC2IJdEEENS0_10in_place_tEDpOT_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<double>::OptionalStorage<double, false>::OptionalStorage<double>(__llvm_libc_20_1_2_::cpp::in_place_t, double&&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::optional")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::in_place_t")] cpp_optional_double_OptionalStorage* @this, [NativeType("double&&")] void* args)
	{
		anon_prxz47* field = &@this->field;
		unchecked
		{
			*(double*)field = *(double*)cpp_forward_double.Invoke(args);
			@this->in_use = 0;
		}
	}
}
