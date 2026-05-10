using System.Runtime.InteropServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("class.__llvm_libc_20_1_2_::internal::ArgList")]
[DemangledName("__llvm_libc_20_1_2_::internal::ArgList")]
public partial struct internal_ArgList
{
	[FieldOffset(0)]
	public InlineArray1_va_list_tag vlist;
}
