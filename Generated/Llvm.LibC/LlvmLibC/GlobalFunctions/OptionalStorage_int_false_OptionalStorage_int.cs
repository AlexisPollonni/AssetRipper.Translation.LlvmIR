using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_int_false_OptionalStorage_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIiE15OptionalStorageIiLb0EEC2IJiEEENS0_10in_place_tEDpOT_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<int>::OptionalStorage<int, false>::OptionalStorage<int>(__llvm_libc_20_1_2_::cpp::in_place_t, int&&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::optional")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::in_place_t")] void* @this, [NativeType("int&&")] void* args)
	{
		unchecked
		{
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt* field = &((cpp_optional_int_OptionalStorage*)@this)->field;
			*(int*)field = *(int*)cpp_forward_int.Invoke(args);
			((cpp_optional_int_OptionalStorage*)@this)->in_use = 0;
		}
	}
}
