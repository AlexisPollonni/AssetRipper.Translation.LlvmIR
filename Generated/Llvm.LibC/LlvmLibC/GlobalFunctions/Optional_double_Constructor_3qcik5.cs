using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_double_Constructor_3qcik5
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIdEC2EOd")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<double>::optional(double&&)")]
	[CleanName("Optional_double_Constructor")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_cpp_optional_vhbvq7* This, [MangledName("t")][NativeType("double&&")] void* T)
	{
		OptionalStorage_double_false_OptionalStorage_double.Invoke(&This->Storage, Cpp_move_double.Invoke(T));
		This->Storage.In_use = 1;
	}
}
