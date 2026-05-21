using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ArgList_Constructor_z4jw9r
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal7ArgListC2ERS1_")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ArgList::ArgList(__llvm_libc_20_1_2_::internal::ArgList&)")]
	[CleanName("ArgList_Constructor")]
	public unsafe static void Invoke(internal_ArgList* @this, [NativeType("__llvm_libc_20_1_2_::internal::ArgList&")] internal_ArgList* other)
	{
		_ = &@this->vlist;
		llvm_va_copy_p0.Invoke(&@this->vlist, &other->vlist);
	}
}
