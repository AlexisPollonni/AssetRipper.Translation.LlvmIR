using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_long_double_false_OptionalStorage_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIeE15OptionalStorageIeLb0EEC2IJeEEENS0_10in_place_tEDpOT_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<long double>::OptionalStorage<long double, false>::OptionalStorage<long double>(__llvm_libc_20_1_2_::cpp::in_place_t, long double&&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::optional")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::in_place_t")] void* @this, [NativeType("long double&&")] void* args)
	{
		unchecked
		{
			anon_mbc8w5* field = &((cpp_optional_long_double_OptionalStorage*)@this)->field;
			*(double*)field = *(double*)cpp_forward_long_double.Invoke(args);
			((cpp_optional_long_double_OptionalStorage*)@this)->field_1 = 0;
		}
	}
}
