using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 32)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_15IntegerToStringIlNS_7details3FmtILh10ELb0ELb0ELb0ELm1EEEEE")]
[MangledName("class.__llvm_libc_20_1_2_::IntegerToString")]
[DemangledName("__llvm_libc_20_1_2_::IntegerToString")]
[CleanName("IntegerToString")]
public partial struct IntegerToString_uuwdyc
{
	[FieldOffset(0)]
	public cpp_array_qkm4kn array;

	[FieldOffset(24)]
	public long written;
}
