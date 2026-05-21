using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Expected_int_int_Constructor_mrm7sc
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8expectedIiiEC2Ei")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::expected<int, int>::expected(int)")]
	[CleanName("Expected_int_int_Constructor")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("exp")][NativeType("int")] int Exp)
	{
		unchecked
		{
			*(int*)(&((Llvm_libc_20_1_2_cpp_optional_int_OptionalStorage*)This)->field) = Exp;
			((Llvm_libc_20_1_2_cpp_optional_int_OptionalStorage*)This)->In_use = 1;
		}
	}
}
