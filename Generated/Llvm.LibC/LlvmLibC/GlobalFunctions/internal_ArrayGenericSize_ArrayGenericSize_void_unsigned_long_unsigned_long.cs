using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal16ArrayGenericSizeC2EPvmm")]
[DemangledName("__llvm_libc_20_1_2_::internal::ArrayGenericSize::ArrayGenericSize(void*, unsigned long, unsigned long)")]
internal static partial class internal_ArrayGenericSize_ArrayGenericSize_void_unsigned_long_unsigned_long
{
	public unsafe static void Invoke(void* @this, void* a, long s, long e)
	{
		unchecked
		{
			((scanf_core_ReadBuffer*)@this)->buffer = a;
			((scanf_core_ReadBuffer*)@this)->buff_len = s;
			((scanf_core_ReadBuffer*)@this)->buff_cur = e;
		}
	}
}
