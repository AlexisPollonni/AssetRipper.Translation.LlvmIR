using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_double_false_OptionalStorage_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIdE15OptionalStorageIdLb0EEC2IJdEEENS0_10in_place_tEDpOT_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<double>::OptionalStorage<double, false>::OptionalStorage<double>(__llvm_libc_20_1_2_::cpp::in_place_t, double&&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::optional")]
	public unsafe static void Invoke([MangledName("this")][NativeType("__llvm_libc_20_1_2_::cpp::in_place_t")] Cpp_optional_double_OptionalStorage* This, [MangledName("args")][NativeType("double&&")] void* Args)
	{
		Anon_prxz47* field = &This->field;
		unchecked
		{
			*(double*)field = *(double*)Cpp_forward_double.Invoke(Args);
			This->In_use = 0;
		}
	}
}
