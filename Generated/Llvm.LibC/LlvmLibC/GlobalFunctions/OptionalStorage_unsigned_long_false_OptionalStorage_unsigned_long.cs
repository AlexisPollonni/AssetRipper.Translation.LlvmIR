using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_unsigned_long_false_OptionalStorage_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalImE15OptionalStorageImLb0EEC2IJmEEENS0_10in_place_tEDpOT_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<unsigned long>::OptionalStorage<unsigned long, false>::OptionalStorage<unsigned long>(__llvm_libc_20_1_2_::cpp::in_place_t, unsigned long&&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::optional")]
	public unsafe static void Invoke([MangledName("this")][NativeType("__llvm_libc_20_1_2_::cpp::in_place_t")] void* This, [MangledName("args")][NativeType("unsigned long&&")] void* Args)
	{
		unchecked
		{
			Llvm_libc_20_1_2_fputil_internal_FPStorage_v3nexn* field = &((Llvm_libc_20_1_2_cpp_expected*)This)->field;
			*(long*)field = *(long*)Cpp_forward_unsigned_long.Invoke(Args);
			((Llvm_libc_20_1_2_cpp_expected*)This)->In_use = 0;
		}
	}
}
