using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_cpp_string_view_false_OptionalStorage_cpp_string_view
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS0_11string_viewEE15OptionalStorageIS2_Lb0EEC2IJS2_EEENS0_10in_place_tEDpOT_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::cpp::string_view>::OptionalStorage<__llvm_libc_20_1_2_::cpp::string_view, false>::OptionalStorage<__llvm_libc_20_1_2_::cpp::string_view>(__llvm_libc_20_1_2_::cpp::in_place_t, __llvm_libc_20_1_2_::cpp::string_view&&)")]
	public unsafe static void Invoke([MangledName("this")][NativeType("__llvm_libc_20_1_2_::cpp::in_place_t")] void* This, [MangledName("args")][NativeType("__llvm_libc_20_1_2_::cpp::string_view&&")] void* Args)
	{
		unchecked
		{
			Llvm_memcpy_p0_p0_i64.Invoke(&((Cpp_optional_cpp_string_view_OptionalStorage*)This)->field, Cpp_forward_cpp_string_view.Invoke(Args), 16L, isVolatile: false);
			((Cpp_optional_cpp_string_view_OptionalStorage*)This)->In_use = 0;
		}
	}
}
