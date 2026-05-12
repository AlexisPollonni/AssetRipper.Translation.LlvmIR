using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal7ArgListC2ERS1_")]
[DemangledName("__llvm_libc_20_1_2_::internal::ArgList::ArgList(__llvm_libc_20_1_2_::internal::ArgList&)")]
internal static partial class internal_ArgList_ArgList_internal_ArgList
{
	public unsafe static void Invoke(internal_ArgList* @this, internal_ArgList* other)
	{
		_ = &@this->vlist;
		llvm_va_copy_p0.Invoke(&@this->vlist, &other->vlist);
	}
}
