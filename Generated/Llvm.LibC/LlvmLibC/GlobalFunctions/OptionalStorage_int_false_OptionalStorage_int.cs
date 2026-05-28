using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_int_false_OptionalStorage_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIiE15OptionalStorageIiLb0EEC2IJiEEENS0_10in_place_tEDpOT_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<int>::OptionalStorage<int, false>::OptionalStorage<int>(__llvm_libc_20_1_2_::cpp::in_place_t, int&&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::optional")]
	public unsafe static void Invoke([MangledName("this")][NativeType("__llvm_libc_20_1_2_::cpp::in_place_t")] void* This, [MangledName("args")][NativeType("int&&")] void* Args)
	{
		unchecked
		{
			Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt* field = &((Cpp_optional_int_OptionalStorage*)This)->field;
			*(int*)field = *(int*)Cpp_forward_int.Invoke(Args);
			((Cpp_optional_int_OptionalStorage*)This)->In_use = 0;
		}
	}
}
