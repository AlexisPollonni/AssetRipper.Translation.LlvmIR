using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ArrayGenericSize_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal16ArrayGenericSizeC2EPvmm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ArrayGenericSize::ArrayGenericSize(void*, unsigned long, unsigned long)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("a")][NativeType("void*")] void* A, [MangledName("s")][NativeType("unsigned long")] long S, [MangledName("e")][NativeType("unsigned long")] long E)
	{
		unchecked
		{
			((Scanf_core_ReadBuffer*)This)->Buffer = A;
			((Scanf_core_ReadBuffer*)This)->Buff_len = S;
			((Scanf_core_ReadBuffer*)This)->Buff_cur = E;
		}
	}
}
