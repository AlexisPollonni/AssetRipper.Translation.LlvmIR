using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_long_long_false_OptionalStorage_long_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIxE15OptionalStorageIxLb0EEC2IJxEEENS0_10in_place_tEDpOT_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<long long>::OptionalStorage<long long, false>::OptionalStorage<long long>(__llvm_libc_20_1_2_::cpp::in_place_t, long long&&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::optional")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::in_place_t")] void* @this, [NativeType("long long&&")] void* args)
	{
		unchecked
		{
			fputil_internal_FPStorage_v3nexn* field = &((cpp_expected*)@this)->field;
			*(long*)field = *(long*)cpp_forward_long_long.Invoke(args);
			((cpp_expected*)@this)->in_use = 0;
		}
	}
}
