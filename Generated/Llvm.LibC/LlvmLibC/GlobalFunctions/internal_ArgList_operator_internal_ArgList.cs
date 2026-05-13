using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal7ArgListaSERS1_")]
[DemangledName("__llvm_libc_20_1_2_::internal::ArgList::operator=(__llvm_libc_20_1_2_::internal::ArgList&)")]
internal static partial class internal_ArgList_operator_internal_ArgList
{
	public unsafe static internal_ArgList* Invoke(internal_ArgList* @this, internal_ArgList* rhs)
	{
		llvm_va_copy_p0.Invoke(&@this->vlist, &rhs->vlist);
		return @this;
	}
}
