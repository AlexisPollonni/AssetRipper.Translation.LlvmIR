using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_8internal7ArgListE")]
[MangledName("class.__llvm_libc_20_1_2_::internal::ArgList")]
[DemangledName("__llvm_libc_20_1_2_::internal::ArgList")]
public partial struct internal_ArgList
{
	[FieldOffset(0)]
	public InlineArray1_va_list_tag vlist;
}
