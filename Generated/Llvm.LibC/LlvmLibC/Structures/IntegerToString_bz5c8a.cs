using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_15IntegerToStringIiNS_7details3FmtILh10ELb0ELb0ELb0ELm1EEEEE")]
[MangledName("class.__llvm_libc_20_1_2_::IntegerToString.6572")]
[DemangledName("__llvm_libc_20_1_2_::IntegerToString")]
[CleanName("IntegerToString")]
public partial struct IntegerToString_bz5c8a
{
	[FieldOffset(0)]
	public Cpp_array_sbzi9g Array;

	[FieldOffset(16)]
	public long Written;
}
