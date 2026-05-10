using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal7ArgListC2EP13__va_list_tag")]
[DemangledName("__llvm_libc_20_1_2_::internal::ArgList::ArgList(__va_list_tag*)")]
internal static partial class internal_ArgList_ArgList_va_list_tag
{
	public unsafe static void Invoke(void* @this, void* vlist)
	{
		unchecked
		{
			_ = &((internal_ArgList*)@this)->vlist;
			llvm_va_copy_p0.Invoke(&((internal_ArgList*)@this)->vlist, vlist);
		}
	}
}
