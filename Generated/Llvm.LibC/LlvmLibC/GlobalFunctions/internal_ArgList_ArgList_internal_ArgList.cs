using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal7ArgListC2ERS1_")]
[DemangledName("__llvm_libc_20_1_2_::internal::ArgList::ArgList(__llvm_libc_20_1_2_::internal::ArgList&)")]
internal static partial class internal_ArgList_ArgList_internal_ArgList
{
	public unsafe static void Invoke(void* @this, void* other)
	{
		unchecked
		{
			_ = &((internal_ArgList*)@this)->vlist;
			llvm_va_copy_p0.Invoke(&((internal_ArgList*)@this)->vlist, &((internal_ArgList*)other)->vlist);
		}
	}
}
