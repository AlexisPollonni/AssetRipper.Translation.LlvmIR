using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_long_false_OptionalStorage_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIlE15OptionalStorageIlLb0EEC2IJlEEENS0_10in_place_tEDpOT_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<long>::OptionalStorage<long, false>::OptionalStorage<long>(__llvm_libc_20_1_2_::cpp::in_place_t, long&&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::optional")]
	public unsafe static void Invoke([MangledName("this")][NativeType("__llvm_libc_20_1_2_::cpp::in_place_t")] void* This, [MangledName("args")][NativeType("long&&")] void* Args)
	{
		unchecked
		{
			Fputil_internal_FPStorage_v3nexn* field = &((Cpp_expected*)This)->field;
			*(long*)field = *(long*)Cpp_forward_long.Invoke(Args);
			((Cpp_expected*)This)->In_use = 0;
		}
	}
}
