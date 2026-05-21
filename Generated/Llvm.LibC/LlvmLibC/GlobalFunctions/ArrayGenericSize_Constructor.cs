using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ArrayGenericSize_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal16ArrayGenericSizeC2EPvmm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ArrayGenericSize::ArrayGenericSize(void*, unsigned long, unsigned long)")]
	public unsafe static void Invoke(void* @this, [NativeType("void*")] void* a, [NativeType("unsigned long")] long s, [NativeType("unsigned long")] long e)
	{
		unchecked
		{
			((scanf_core_ReadBuffer*)@this)->buffer = a;
			((scanf_core_ReadBuffer*)@this)->buff_len = s;
			((scanf_core_ReadBuffer*)@this)->buff_cur = e;
		}
	}
}
