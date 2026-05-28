using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ArrayFixedSize_16ul_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal14ArrayFixedSizeILm16EEC2EPvm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ArrayFixedSize<16ul>::ArrayFixedSize(void*, unsigned long)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("a")][NativeType("void*")] void* A, [MangledName("s")][NativeType("unsigned long")] long S)
	{
		unchecked
		{
			((Cpp_string_view*)This)->Span_data = A;
			((Cpp_string_view*)This)->Span_size = S;
		}
	}
}
