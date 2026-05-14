using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_6fputil12TripleDoubleE")]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::TripleDouble")]
[DemangledName("__llvm_libc_20_1_2_::fputil::TripleDouble")]
public partial struct fputil_TripleDouble
{
	[FieldOffset(0)]
	public double lo;

	[FieldOffset(8)]
	public double mid;

	[FieldOffset(16)]
	public double hi;
}
