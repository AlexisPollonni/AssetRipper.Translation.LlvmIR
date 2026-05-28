using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ArgList_Assignment
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal7ArgListaSERS1_")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ArgList::operator=(__llvm_libc_20_1_2_::internal::ArgList&)")]
	public unsafe static Internal_ArgList* Invoke([MangledName("this")] Internal_ArgList* This, [MangledName("rhs")][NativeType("__llvm_libc_20_1_2_::internal::ArgList&")] Internal_ArgList* Rhs)
	{
		Llvm_va_copy_p0.Invoke(&This->Vlist, &Rhs->Vlist);
		return This;
	}
}
